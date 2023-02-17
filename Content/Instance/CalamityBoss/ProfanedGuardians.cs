using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class ProfanedGuardians : BaseTitle {

        public override string Subtitle => "Watchers of the Diminished Flame";
        public override string Title    => "The Profaned Guardians";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.868, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(1.0, 0.75, 1.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.ProfanedGuardianCommander.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.ProfanedGuardianDefender.type) || NPCUtil.IsNPCTypeRelevant(CalamityNPCID.ProfanedGuardianHealer.type);
        }

    }
}
