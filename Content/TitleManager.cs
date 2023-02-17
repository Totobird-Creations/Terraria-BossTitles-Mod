using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent;
using Terraria.UI;
using Terraria.UI.Chat;
using boss_titles.Util;


namespace boss_titles.Content {

	[Autoload(Side = ModSide.Client)]
    internal class TitleManager : ModSystem {

        // Rendering settings.

        public DynamicSpriteFont font = FontAssets.DeathText.Value;

        public float subtitle_scale        = 0.75f;
        public float title_scale_min       = 1.5f;
        public float title_scale_max       = 1.75f;
        public float title_spacing         = -35.0f;
        public float title_offset          = -150.0f;
        public float title_pulse_distance  = 5.0f;
        public int   title_intersperse_max = 5;

        public double animation_showing_subtitle_length      = 1.0d;
        public double animation_waiting_to_show_title_length = 0.25d;
        public double animation_showing_title_length         = 0.25d;
        public double animation_title_pulsing_length         = 0.25d;
        public double animation_waiting_to_hide_length       = 0.5d;
        public double animation_hiding_length                = 0.5d;
        public double animation_cooldown_length              = 0.125d;

        // Internal values.

        internal List<BaseTitle> titles;
        internal List<BaseTitle> animation_queue;

        internal AnimationState animation_state    = AnimationState.Disabled;
        internal double         animation_progress = 0.0d;

        internal GameTime       time;


        public override void OnModLoad() {
            base.OnModLoad();

            this.titles = new List<BaseTitle>();
            foreach (Type type in boss_titles.instance.Code.GetTypes().Where(type => ! type.IsAbstract && type.IsSubclassOf(typeof(BaseTitle)))) {
                this.titles.Add((BaseTitle)Activator.CreateInstance(type));
            }
            this.animation_queue = new List<BaseTitle>();
        }


        public override void OnModUnload() {
            base.OnModUnload();

            this.titles          = null;
            this.animation_queue = null;
        }


        public override void UpdateUI(GameTime time) {
            base.UpdateUI(time);
            this.time = time;

            foreach (BaseTitle title in this.titles) {
                if (! title.was_active && title.IsActive() && ! this.animation_queue.Contains(title)) {
                    this.animation_queue.Add(title);
                }
                title.was_active = title.IsActive();
            }

            switch (this.animation_state) {
                case AnimationState.Disabled:
                    if (this.animation_queue.Count > 0) {
                        this.animation_state = AnimationState.ShowingSubtitle;
                    }
                    break;
                default:
                    this.animation_progress = Math.Min(1.0d, this.animation_progress + time.ElapsedGameTime.TotalSeconds / this.GetAnimationLength(this.animation_state));
                    if (this.animation_progress >= 1.0d) {
                        this.animation_progress = 0.0d;
                        this.animation_state += 1;
                        if (this.animation_state >= AnimationState.Max) {
                            this.animation_state = AnimationState.Disabled;
                            this.animation_queue.RemoveAt(0);
                        }
                    }
                    break;
            }
        }


        internal double GetAnimationLength(AnimationState state) {
            switch (state) {
                case AnimationState.ShowingSubtitle    : return this.animation_showing_subtitle_length;
                case AnimationState.WaitingToShowTitle : return this.animation_waiting_to_show_title_length;
                case AnimationState.ShowingTitle       : return this.animation_showing_title_length;
                case AnimationState.TitlePulsing       : return this.animation_title_pulsing_length;
                case AnimationState.WaitingToHide      : return this.animation_waiting_to_hide_length;
                case AnimationState.Hiding             : return this.animation_hiding_length;
                case AnimationState.Cooldown           : return this.animation_cooldown_length;
                default                                : return 1.0d;
            }
        }


        public void Draw(GameTime time) {
            if (this.animation_queue.Count > 0) {
                BaseTitle data                       = this.animation_queue[0];
                string    real_subtitle              = this.Intersperse(this.BossRushActive() ? "Boss Rush" : data.Subtitle, " ");
                string    subtitle                   = this.TypeOutSubtitle(real_subtitle);
                double    title_intersperse_progress = this.animation_state == AnimationState.ShowingTitle ? 1.0d - this.animation_progress : 0.0d;
                string    title                      = this.Intersperse(data.Title, new string(' ', (int)Math.Ceiling(title_intersperse_progress * (double)title_intersperse_max)));

                Vector2 center        = new Vector2(Main.screenWidth * 0.5f, Main.screenHeight * 0.5f + this.title_offset);
                double  primary_alpha = this.GetPrimaryAlpha();

                Vector2 subtitle_scale = new Vector2(this.subtitle_scale, this.subtitle_scale);
                Vector2 subtitle_size  = ChatManager.GetStringSize(this.font, real_subtitle, subtitle_scale);
                Vector2 subtitle_pos   = new Vector2(center.X - subtitle_size.X / 2.0f, center.Y - subtitle_size.Y - this.title_spacing / 2.0f);
                this.DrawTextWithShadow(subtitle, subtitle_pos, subtitle_scale, data.GetSubtitleColour(time), primary_alpha, 0.0f);

                double  title_scale_u    = 1.31d;
                double  title_scale_p    = this.animation_state == AnimationState.ShowingTitle ? this.animation_progress : 1.0d;
                float   real_title_scale = this.title_scale_min + (this.title_scale_max - this.title_scale_min) *
                    (float)Math.Max(Math.Max(1.1d * (-1.0d * Math.Pow(title_scale_u * title_scale_p - 1.0d, 2.0d) + 1.0d), 0.0d), Math.Floor(title_scale_u * Math.Max(Math.Min(title_scale_p, 1.0d / title_scale_u), 0.0d)));
                Vector2 title_scale      = new Vector2(real_title_scale, real_title_scale);
                Vector2 title_size       = ChatManager.GetStringSize(this.font, title, title_scale);
                Vector2 title_pos        = new Vector2(center.X - title_size.X / 2.0f, center.Y + this.title_spacing / 2.0f);
                double  title_alpha      = primary_alpha * this.GetTitleAlpha();

                float shadow_spread = this.animation_state == AnimationState.TitlePulsing
                    ? (float)Math.Sqrt(1.0d - Math.Pow(2.0d * this.animation_progress - 1.0d, 2.0d))
                    : 0.0f;
                this.DrawTextWithShadow(title, title_pos, title_scale, data.GetTitleColour(time), title_alpha, shadow_spread);

            }
        }


        internal bool BossRushActive() {
            return boss_titles.calamity_mod != null && (
                (bool)boss_titles.calamity_mod.GetType().Assembly
                    .GetType("CalamityMod.Events.BossRushEvent", false, false)
                    .GetField("BossRushActive")
                    .GetValue(null)
            );
        }


        internal string Intersperse(string text, string separator) {
            string res   = "";
            bool   first = true;
            foreach (char ch in text) {
                if (first) {
                    first = false;
                } else {
                    res += separator;
                }
                res += ch;
            }
            return res;
        }


        internal string TypeOutSubtitle(string text) {
            if (this.animation_state > AnimationState.Disabled && this.animation_state < AnimationState.Cooldown) {
                if (this.animation_state == AnimationState.ShowingSubtitle) {
                    return text.Substring(0, Math.Min(text.Length, (int)Math.Floor(text.Length * this.animation_progress)));
                }
                return text;
            }
            return string.Empty;
        }


        internal void DrawTextWithShadow(string text, Vector2 pos, Vector2 scale, RGBA colour, double alpha, float shadow_spread) {
            if (alpha > 0.0d) {
                ChatManager.DrawColorCodedStringWithShadow(
                    Main.spriteBatch, font,
                    text, pos,
                    colour.Multiply(alpha).IntoColour(),
                    0.0f, Vector2.Zero,
                    scale,
                    -1.0f,
                    2.0f + (this.title_pulse_distance - 2.0f) * shadow_spread
                );
            }
        }


        internal double GetPrimaryAlpha() {
            if (this.animation_state > AnimationState.Disabled && this.animation_state < AnimationState.Cooldown) {
                if (this.animation_state == AnimationState.Hiding) {
                    return 1.0d - this.animation_progress;
                }
                return 1.0d;
            }
            return 0.0d;
        }

        
        internal double GetTitleAlpha() {
            if (this.animation_state >= AnimationState.ShowingTitle && this.animation_state < AnimationState.Cooldown) {
                if (this.animation_state == AnimationState.ShowingTitle) {
                    return this.animation_progress;
                }
                return 1.0d;
            }
            return 0.0d;
        }


        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers) {
            base.ModifyInterfaceLayers(layers);

            int i = layers.FindIndex((layer) => layer.Name == "Vanilla: Inventory");
            LegacyGameInterfaceLayer layer = new LegacyGameInterfaceLayer(
                "boss_titles: Title",
                delegate {
                    this.Draw(this.time);
                    return true;
                },
                InterfaceScaleType.UI
            );
            if (i == -1) {
                layers.Insert(i, layer);
            } else {
                layers.Add(layer);
            }

        }

    }


    internal enum AnimationState : uint {
        Disabled,           // Nothing is showing.
        ShowingSubtitle,    // Subtitle is being typed out.
        WaitingToShowTitle, // Pause between subtitle shown and title showing.
        ShowingTitle,       // Title is fading in.
        TitlePulsing,       // Title shadows are moving outward.
        WaitingToHide,      // Pause between title shown and fade out.
        Hiding,             // Title and subtitle are fading out.
        Cooldown,           // Nothing is showing, used to keep multiple displays from showing at the same time.

        Max // Used as a marker.
    }

}
