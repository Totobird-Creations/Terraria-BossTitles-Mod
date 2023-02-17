using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class QueenSlime : BaseTitle {

        public override string Subtitle => "Gelatinous Sovereign";
        public override string Title    => "Queen Slime";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.498, 0.184, 1.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.624, 0.31, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.QueenSlimeBoss);
        }

    }
}
