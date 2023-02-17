using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class MoonLord : BaseTitle {

        public override string Subtitle => "Eldritch Demise";
        public override string Title    => "Moon Lord";

        private double animation_progress = 0.0d;

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.0, 1.0, 0.875);
        }
        public override RGBA GetTitleColour(GameTime time) {
            this.animation_progress = (this.animation_progress + time.ElapsedGameTime.TotalSeconds * 5.0d) % 1.0d;
            return RGBA.HSV(161.2d, Math.Cos(Math.Tau * this.animation_progress) / 2.0d + 0.5d, 1.0d);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.MoonLordCore);
        }

    }
}
