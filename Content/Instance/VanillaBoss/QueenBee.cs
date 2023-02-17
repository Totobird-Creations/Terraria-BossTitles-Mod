using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class QueenBee : BaseTitle {

        public override string Subtitle => "Matriarch of the Jungle Hives";
        public override string Title    => "Queen Bee";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.749, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.624, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.QueenBee);
        }

    }
}
