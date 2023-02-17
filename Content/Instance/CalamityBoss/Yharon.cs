using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Yharon : BaseTitle {

        public override string Subtitle => "Unwavering Brute";
        public override string Title    => "Yharon";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.31, 0.373);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.624, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Yharon.type);
        }

    }
}
