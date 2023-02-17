using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.UI;
using Terraria.ModLoader;
using boss_titles.Bridge;
using boss_titles.Content;


namespace boss_titles {

	public class boss_titles : Mod {

		internal static boss_titles instance;

		internal static Mod calamity_mod;

		public override void Load() {
			boss_titles.instance = this;
			ModLoader.TryGetMod("CalamityMod", out boss_titles.calamity_mod);
		}

		public override void Unload() {
			boss_titles.instance     = null;
			boss_titles.calamity_mod = null;
		}

	}

}
