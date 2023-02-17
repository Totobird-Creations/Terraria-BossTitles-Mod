using System;
using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Providence : BaseTitle {

        public override string Subtitle => "Glare of Purity";
        public override string Title    => "Providence";

        private double animation_progress = 0.0d;

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.561, 0.5, 0.561);
        }
        public override RGBA GetTitleColour(GameTime time) {
            this.animation_progress = (this.animation_progress + time.ElapsedGameTime.TotalSeconds * 5.0d) % 1.0d;
            RGBA a = new RGBA(1.0, 0.5, 0.0);
            RGBA b = new RGBA(0.624, 0.373, 0.0);
            double i = Math.Cos(Math.Tau * this.animation_progress) / 2.0d + 0.5d;
            return new RGBA(
                a.r + (b.r - a.r) * i,
                a.g + (b.g - a.g) * i,
                a.b + (b.b - a.b) * i,
                a.a + (b.a - a.a) * i
            );
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Providence.type);
        }

    }
}
