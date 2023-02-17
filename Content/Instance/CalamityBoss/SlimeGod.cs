using System;
using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class SlimeGod : BaseTitle {

        public override string Subtitle => "Bubbling Sludge";
        public override string Title    => "The Slime God";

        private double animation_progress = 0.0d;

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.5, 0.5, 0.5);
        }
        public override RGBA GetTitleColour(GameTime time) {
            this.animation_progress = (this.animation_progress + time.ElapsedGameTime.TotalSeconds * 5.0d) % 1.0d;
            RGBA a = new RGBA(0.443, 0.271, 0.431);
            RGBA b = new RGBA(1.0, 0.255, 0.294);
            double i = Math.Cos(Math.Tau * this.animation_progress) / 2.0d + 0.5d;
            return new RGBA(
                a.r + (b.r - a.r) * i,
                a.g + (b.g - a.g) * i,
                a.b + (b.b - a.b) * i,
                a.a + (b.a - a.a) * i
            );
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.SlimeGodCore.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.CrimulanSlimeGod.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.EbonianSlimeGod.type);
        }

    }
}
