using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class SkeletronPrime : BaseTitle {

        public override string Subtitle => "Mechanical Bringer of Dread";
        public override string Title    => "Skeletron Prime";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.0, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.5, 0.5, 0.5);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.SkeletronPrime);
        }

    }
}
