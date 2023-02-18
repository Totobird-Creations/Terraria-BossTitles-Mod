using System;
using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class AdultEidolonWyrm : BaseTitle {

        public override string Subtitle => "Ensemble Of Fools";
        public override string Title    => "The Boss Rush";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.875, 0.875, 0.875);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 1.0, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.BossRushActive();
        }

    }
}
