using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Anahita : BaseTitle {

        public override string Subtitle => "Forgotten Manipulator of Seas";
        public override string Title    => "Anahita";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.65, 0.65, 0.65);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.573, 0.702, 0.961);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.Anahita.type);
        }

    }
}
