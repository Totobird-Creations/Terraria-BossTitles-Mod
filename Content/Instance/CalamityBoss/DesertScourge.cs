using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class DesertScourge : BaseTitle {

        public override string Subtitle => "Guardian of the Former Seas";
        public override string Title    => "The Desert Scourge";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.612, 0.525, 0.388);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.463, 0.322, 0.196);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.DesertScourgeHead.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.DesertScourgeBody.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.DesertScourgeTail.type);
        }

    }
}
