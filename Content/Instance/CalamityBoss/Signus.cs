using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Signus : BaseTitle {

        public override string Subtitle => "The Envoy";
        public override string Title    => "Signus";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.624, 0.0, 0.75);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.5, 0.0, 0.75);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Signus.type);
        }

    }
}
