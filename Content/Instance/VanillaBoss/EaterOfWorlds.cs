using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class EaterOfWorlds : BaseTitle {

        public override string Subtitle => "Source of Screams";
        public override string Title    => "The Eater of Worlds";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.233, 0.0, 0.624);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.373, 0.0, 0.624);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.EaterofWorldsHead) || NPCUtil.IsNPCTypeRelevant(NPCID.EaterofWorldsBody) || NPCUtil.IsNPCTypeRelevant(NPCID.EaterofWorldsTail);
        }

    }
}
