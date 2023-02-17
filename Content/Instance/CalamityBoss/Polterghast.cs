using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Polterghast : BaseTitle {

        public override string Subtitle => "Cacophony of Anguished Spirits";
        public override string Title    => "The Polterghast";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.498, 0.561, 0.624);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.5, 0.875, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Polterghast.type);
        }

    }
}
