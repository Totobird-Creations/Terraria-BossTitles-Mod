using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Leviathan : BaseTitle {

        public override string Subtitle => "Suboceanic Beast";
        public override string Title    => "The Leviathan";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.75, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.275, 0.824, 0.533);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Leviathan.type);
        }

    }
}
