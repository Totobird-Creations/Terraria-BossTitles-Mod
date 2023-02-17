using Microsoft.Xna.Framework;
using boss_titles.Bridge;
using boss_titles.Util;


namespace boss_titles.Content.Instance.CalamityBoss {
    public class Ravager : BaseTitle {

        public override string Subtitle => "Twisted Golem";
        public override string Title    => "The Ravager";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.373, 0.247, 0.624);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.75, 0.153, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(CalamityNPCID.RavagerBody.type);
        }

    }
}
