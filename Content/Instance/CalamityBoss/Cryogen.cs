using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Cryogen : BaseTitle {

        public override string Subtitle => "Archmage's Prison";
        public override string Title    => "Cryogen";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.0, 0.75, 0.875);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.624, 1.0, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Cryogen.type);
        }

    }
}
