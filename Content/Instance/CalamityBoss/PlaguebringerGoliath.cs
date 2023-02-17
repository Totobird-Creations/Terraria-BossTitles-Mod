using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class PlaguebringerGoliath : BaseTitle {

        public override string Subtitle => "Pestiferous Arthropod";
        public override string Title    => "The Plaguebringer Goliath";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.31, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.75, 1.0, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.PlaguebringerGoliath.type);
        }

    }
}
