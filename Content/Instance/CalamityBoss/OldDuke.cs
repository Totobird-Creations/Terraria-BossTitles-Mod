using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class OldDuke : BaseTitle {

        public override string Subtitle => "Mutant Horror of the Seas";
        public override string Title    => "The Old Duke";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.561, 0.5, 0.624);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.624, 0.5, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.OldDuke.type);
        }

    }
}
