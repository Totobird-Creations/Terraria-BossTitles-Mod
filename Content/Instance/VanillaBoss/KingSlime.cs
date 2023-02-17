using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class KingSlime : BaseTitle {

        public override string Subtitle => "Lord of Ooze";
        public override string Title    => "King Slime";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.306, 0.518, 0.788);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.306, 0.639, 0.788);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.KingSlime);
        }

    }
}
