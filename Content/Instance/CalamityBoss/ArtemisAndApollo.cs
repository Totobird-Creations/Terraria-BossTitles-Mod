using System;
using Microsoft.Xna.Framework;
using Terraria;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class ArtemisAndApollo : BaseTitle {

        public override string Subtitle => "The Supreme Hunters";
        public override string Title    => "Artemis and Apollo";

        private double animation_progress = 0.0f;

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.498, 0.561, 0.624);
        }
        public override RGBA GetTitleColour(GameTime time) {
            this.animation_progress = (this.animation_progress + time.ElapsedGameTime.TotalSeconds * 2.0d) % 1.0d;
            return RGBA.HSV(360.0d * this.animation_progress, 1.0d, 1.0d);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Artemis.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Apollo.type);
        }

    }
}
