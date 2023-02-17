using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class LunaticCultist : BaseTitle {

        public override string Subtitle => "Devotee to Impending Doom";
        public override string Title    => "The Lunatic Cultist";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.0, 0.498, 0.937);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.0, 0.373, 0.937);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.CultistBoss);
        }

    }
}
