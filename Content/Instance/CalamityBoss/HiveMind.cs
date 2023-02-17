using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class HiveMind : BaseTitle {

        public override string Subtitle => "Corrupted Perception";
        public override string Title    => "The Hive Mind";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.561, 0.373, 0.624);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.5, 0.25, 0.75);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.HiveMind.type);
        }

    }
}
