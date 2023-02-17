using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class Skeletron : BaseTitle {

        public override string Subtitle => "Cursed Guardian";
        public override string Title    => "Skeletron";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.561, 0.498, 0.561);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.498, 0.561, 0.498);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.SkeletronHead);
        }

    }
}
