using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class CeaselessVoid : BaseTitle {

        public override string Subtitle => "A Slice in the Fabric of Reality";
        public override string Title    => "The Ceaseless Void";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.62, 0.318, 0.6);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.047, 0.071, 0.11);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.CeaselessVoid.type);
        }

    }
}
