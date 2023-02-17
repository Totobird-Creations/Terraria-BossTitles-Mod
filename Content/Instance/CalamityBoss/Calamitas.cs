using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Calamitas : BaseTitle {

        public override string Subtitle => "Crippled Doppelganger";
        public override string Title    => "Calamitas";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.51, 0.42, 0.42);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.89, 0.31, 0.31);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Calamitas.type);
        }

    }
}
