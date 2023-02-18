using Terraria;


namespace boss_titles.Util {

    public class NPCUtil {

        public static bool IsNPCTypeRelevant(int? npc_type) {
            return npc_type.HasValue && (Main.LocalPlayer.isNearNPC(npc_type.Value, 2700.0f) || NPCUtil.BossRushActive());
        }

        public static bool BossRushActive() {
            return boss_titles.calamity_mod != null && (
                (bool)boss_titles.calamity_mod.GetType().Assembly
                    .GetType("CalamityMod.Events.BossRushEvent", false, false)
                    .GetField("BossRushActive")
                    .GetValue(null)
            );
        }

    }

}
