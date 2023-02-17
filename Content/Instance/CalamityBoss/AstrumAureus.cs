using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class AstrumAureus : BaseTitle {

        public override string Subtitle => "Infected Stomper";
        public override string Title    => "Astrum Aureus";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.733, 0.863, 0.929);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.929, 0.365, 0.322);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AstrumAureus.type);
        }

    }
}
