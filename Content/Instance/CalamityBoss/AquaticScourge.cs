using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class AquaticScourge : BaseTitle {

        public override string Subtitle => "Polluted Hunger";
        public override string Title    => "The Aquatic Scourge";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.82, 0.776, 0.616);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.655, 0.788, 0.475);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AquaticScourgeHead.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AquaticScourgeBody.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.AquaticScourgeTail.type);
        }

    }
}
