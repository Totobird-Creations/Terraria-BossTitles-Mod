using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Perforators : BaseTitle {

        public override string Subtitle => "Writhing Abomination";
        public override string Title    => "The Perforators";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.875, 1.0, 1.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.373, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.PerforatorHive.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.SmallPerforator.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.MediumPerforator.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.LargePerforator.type);
        }

    }
}
