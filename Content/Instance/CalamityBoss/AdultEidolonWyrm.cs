using System;
using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class AdultEidolonWyrm : BaseTitle {

        public override string Subtitle => "A Glimpse Into the Full Potential of Nature";
        public override string Title    => "The Eidolon Wyrm";

        private double animation_progress = 0.0d;

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.376, 0.42, 0.439);
        }
        public override RGBA GetTitleColour(GameTime time) {
            this.animation_progress = (this.animation_progress + time.ElapsedGameTime.TotalSeconds * 5.0d) % 1.0d;
            RGBA a = new RGBA(0.459, 0.976, 0.976);
            RGBA b = new RGBA(1.0, 1.0, 0.569);
            double i = Math.Cos(Math.Tau * this.animation_progress) / 2.0d + 0.5d;
            return new RGBA(
                a.r + (b.r - a.r) * i,
                a.g + (b.g - a.g) * i,
                a.b + (b.b - a.b) * i,
                a.a + (b.a - a.a) * i
            );
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AdultEidolonWyrmHead.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AdultEidolonWyrmBody.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AdultEidolonWyrmTail.type);
        }

    }
}
