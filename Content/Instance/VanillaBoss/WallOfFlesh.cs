using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class WallOfFlesh : BaseTitle {

        public override string Subtitle => "Horrific Blockade";
        public override string Title    => "The Wall of Flesh";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.875, 0.31, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.0, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.WallofFlesh);
        }

    }
}
