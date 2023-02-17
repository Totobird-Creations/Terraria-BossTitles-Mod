using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class Destroyer : BaseTitle {

        public override string Subtitle => "Contraption of Excavation";
        public override string Title    => "The Destroyer";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.0, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.5, 0.5, 0.5);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.TheDestroyer) || NPCUtil.IsNPCTypeRelevant(NPCID.TheDestroyerBody) || NPCUtil.IsNPCTypeRelevant(NPCID.TheDestroyerTail);
        }

    }
}
