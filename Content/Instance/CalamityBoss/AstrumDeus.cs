using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class AstrumDeus : BaseTitle {

        public override string Subtitle => "Fragments of a Star God";
        public override string Title    => "Astrum Deus";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.278, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.0, 0.875, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AstrumDeusHead.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AstrumDeusBody.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AstrumDeusTail.type);
        }

    }
}
