using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using boss_titles.Util;


namespace boss_titles.Content.Instance.VanillaBoss {
    public class DukeFishron : BaseTitle {

        public override string Subtitle => "Mutant Terror of the Seas";
        public override string Title    => "Duke Fishron";

        public override RGBA GetSubtitleColour(GameTime time) {
            return new RGBA(0.0, 0.749, 0.498);
        }
        public override RGBA GetTitleColour(GameTime time) {
            return new RGBA(0.0, 0.883, 0.587);
        }

        public override bool IsActive() {
            return NPCUtil.IsNPCTypeRelevant(NPCID.DukeFishron);
        }

    }
}
