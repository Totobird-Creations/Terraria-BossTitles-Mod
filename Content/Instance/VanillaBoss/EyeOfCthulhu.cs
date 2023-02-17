using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class EyeOfCthulhu : BaseTitle {

        public override string Subtitle => "Overseer of Evil";
        public override string Title    => "The Eye of Cthulhu";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.663, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.449, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.EyeofCthulhu);
        }

    }
}
