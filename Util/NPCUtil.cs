using Terraria;


namespace boss_titles.Util {

    public class NPCUtil {

        public static bool IsNPCTypeRelevant(int? npc_type) {
            return npc_type.HasValue && Main.LocalPlayer.isNearNPC(npc_type.Value, 2700.0f);
        }

    }

}
