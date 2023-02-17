using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class Plantera : BaseTitle {

        public override string Subtitle => "Carnivorous Overgrowth";
        public override string Title    => "Plantera";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.373, 0.812, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.435, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.Plantera);
        }

    }
}
