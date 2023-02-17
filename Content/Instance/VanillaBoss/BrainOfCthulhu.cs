using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class BrainOfCthulhu : BaseTitle {

        public override string Subtitle => "Imperceptible Mind";
        public override string Title    => "The Brain of Cthulhu";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.373, 0.373);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.247, 0.247);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.BrainofCthulhu);
        }

    }
}
