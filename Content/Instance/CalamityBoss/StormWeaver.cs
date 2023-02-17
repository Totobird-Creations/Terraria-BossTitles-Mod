using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class StormWeaver : BaseTitle {

        public override string Subtitle => "Cosmic Serpent";
        public override string Title    => "The Storm Weaver";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.737, 0.0, 1.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.0, 1.0, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.StormWeaverHead.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.StormWeaverBody.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.StormWeaverTail.type);
        }

    }
}
