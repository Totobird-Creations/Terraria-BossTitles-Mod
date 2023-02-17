using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class Twins : BaseTitle {

        public override string Subtitle => "Retinazer and Spazmatism";
        public override string Title    => "The Twins";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.0, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.5, 0.5, 0.5);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.Retinazer) || NPCUtil.IsNPCTypeRelevant(NPCID.Spazmatism);
        }

    }
}
