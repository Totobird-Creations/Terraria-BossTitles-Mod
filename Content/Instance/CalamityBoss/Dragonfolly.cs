using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Dragonfolly : BaseTitle {

        public override string Subtitle => "Failed Experiment";
        public override string Title    => "The Dragonfolly";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.5, 0.373, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.561, 0.31, 0.5);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Dragonfolly.type);
        }

    }
}
