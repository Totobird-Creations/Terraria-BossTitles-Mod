using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Crabulon : BaseTitle {

        public override string Subtitle => "Fungal Carcass";
        public override string Title    => "Crabulon";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.89, 0.878, 0.729);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.522, 1.0, 0.929);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Crabulon.type);
        }

    }
}
