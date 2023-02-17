using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class TorchGod : BaseTitle {

        public override string Subtitle => "Deity of Eternal Flickering";
        public override string Title    => "The Torch God";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.718, 0.38, 0.09);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.918, 0.224);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.TorchGod);
        }

    }
}
