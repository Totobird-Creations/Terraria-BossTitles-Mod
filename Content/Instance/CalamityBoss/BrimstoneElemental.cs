using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class BrimstoneElemental : BaseTitle {

        public override string Subtitle => "Refengeful Fallen";
        public override string Title    => "The Brimstone Elemental";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.678, 0.204, 0.275);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.89, 0.31, 0.31);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.BrimstoneElemental.type);
        }

    }
}
