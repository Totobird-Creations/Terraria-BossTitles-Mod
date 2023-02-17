using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class Golem : BaseTitle {

        public override string Subtitle {get;} = "Archaic Idol";
        public override string Title    {get;} = "The Golem";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(1.0, 0.875, 0.0);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.624, 0.373, 0.0);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.Golem);
        }

    }
}
