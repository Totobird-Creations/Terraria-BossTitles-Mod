using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class DevourerOfGods : BaseTitle {

        public override string Subtitle => "Scourge of the Universe";
        public override string Title    => "The Devourer Of Gods";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.416, 0.4, 0.6);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.5, 0.8);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.DevourerOfGodsHead.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.DevourerOfGodsBody.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.DevourerOfGodsTail.type);
        }

    }
}
