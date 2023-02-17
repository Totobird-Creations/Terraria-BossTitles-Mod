using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace boss_titles.Bridge {

	public class CalamityNPCID {

        public static CalamityNPC DesertScourgeHead         = new CalamityNPC("DesertScourgeHead");
        public static CalamityNPC DesertScourgeBody         = new CalamityNPC("DesertScourgeBody");
        public static CalamityNPC DesertScourgeTail         = new CalamityNPC("DesertScourgeTail");
        public static CalamityNPC Crabulon                  = new CalamityNPC("Crabulon");
        public static CalamityNPC HiveMind                  = new CalamityNPC("HiveMind");
        public static CalamityNPC PerforatorHive            = new CalamityNPC("PerforatorHive");
        public static CalamityNPC SmallPerforator           = new CalamityNPC("SmallPerforator");
        public static CalamityNPC MediumPerforator          = new CalamityNPC("MediumPerforator");
        public static CalamityNPC LargePerforator           = new CalamityNPC("LargePerforator");
        public static CalamityNPC SlimeGodCore              = new CalamityNPC("SlimeGodCore");
        public static CalamityNPC CrimulanSlimeGod          = new CalamityNPC("CrimulanSlimeGod");
        public static CalamityNPC EbonianSlimeGod           = new CalamityNPC("EbonianSlimeGod");
        public static CalamityNPC Cryogen                   = new CalamityNPC("Cryogen");
        public static CalamityNPC AquaticScourgeHead        = new CalamityNPC("AquaticScourgeHead");
        public static CalamityNPC AquaticScourgeBody        = new CalamityNPC("AquaticScourgeBody");
        public static CalamityNPC AquaticScourgeTail        = new CalamityNPC("AquaticScourgeTail");
        public static CalamityNPC BrimstoneElemental        = new CalamityNPC("BrimstoneElemental");
        public static CalamityNPC Calamitas                 = new CalamityNPC("CalamitasClone");
        public static CalamityNPC Cataclysm                 = new CalamityNPC("Cataclysm");
        public static CalamityNPC Catastrophe               = new CalamityNPC("Catastrophe");
        public static CalamityNPC Leviathan                 = new CalamityNPC("Leviathan");
        public static CalamityNPC Anahita                   = new CalamityNPC("Anahita");
        public static CalamityNPC AstrumAureus              = new CalamityNPC("AstrumAureus");
        public static CalamityNPC PlaguebringerGoliath      = new CalamityNPC("PlaguebringerGoliath");
        public static CalamityNPC RavagerBody               = new CalamityNPC("RavagerBody");
        public static CalamityNPC AstrumDeusHead            = new CalamityNPC("AstrumDeusHead");
        public static CalamityNPC AstrumDeusBody            = new CalamityNPC("AstrumDeusBody");
        public static CalamityNPC AstrumDeusTail            = new CalamityNPC("AstrumDeusTail");
        public static CalamityNPC ProfanedGuardianCommander = new CalamityNPC("ProfanedGuardianCommander");
        public static CalamityNPC ProfanedGuardianDefender  = new CalamityNPC("ProfanedGuardianDefender");
        public static CalamityNPC ProfanedGuardianHealer    = new CalamityNPC("ProfanedGuardiaHealerr");
        public static CalamityNPC Dragonfolly               = new CalamityNPC("Bumblefuck");
        public static CalamityNPC Providence                = new CalamityNPC("Providence");
        public static CalamityNPC StormWeaverHead           = new CalamityNPC("StormWeaverHead");
        public static CalamityNPC StormWeaverBody           = new CalamityNPC("StormWeaverBody");
        public static CalamityNPC StormWeaverTail           = new CalamityNPC("StormWeaverTail");
        public static CalamityNPC CeaselessVoid             = new CalamityNPC("CeaselessVoid");
        public static CalamityNPC Signus                    = new CalamityNPC("Signus");
        public static CalamityNPC Polterghast               = new CalamityNPC("Polterghast");
        public static CalamityNPC OldDuke                   = new CalamityNPC("OldDuke");
        public static CalamityNPC DevourerOfGodsHead        = new CalamityNPC("DevourerofGodsHead");
        public static CalamityNPC DevourerOfGodsBody        = new CalamityNPC("DevourerofGodsBody");
        public static CalamityNPC DevourerOfGodsTail        = new CalamityNPC("DevourerofGodsTail");
        public static CalamityNPC Yharon                    = new CalamityNPC("Yharon");
        public static CalamityNPC Draedon                   = new CalamityNPC("Draedon");
        public static CalamityNPC AresBody                  = new CalamityNPC("AresBody");
        public static CalamityNPC Artemis                   = new CalamityNPC("Artemis");
        public static CalamityNPC Apollo                    = new CalamityNPC("Apollo");
        public static CalamityNPC ThanatosHead              = new CalamityNPC("ThanatosHead");
        public static CalamityNPC ThanatosBody              = new CalamityNPC("ThanatosBody");
        public static CalamityNPC ThanatosTail              = new CalamityNPC("ThanatosTail");
        public static CalamityNPC SupremeCalamitas          = new CalamityNPC("SupremeCalamitas");
        public static CalamityNPC SupremeCataclysm          = new CalamityNPC("SupremeCataclysm");
        public static CalamityNPC SupremeCatastrophe        = new CalamityNPC("SupremeCatastrophe");
        public static CalamityNPC AdultEidolonWyrmHead      = new CalamityNPC("AdultEidolonWyrmHead");
        public static CalamityNPC AdultEidolonWyrmBody      = new CalamityNPC("AdultEidolonWyrmBody");
        public static CalamityNPC AdultEidolonWyrmTail      = new CalamityNPC("AdultEidolonWyrmTail");

    }

    public class CalamityNPC {

        public  int?   type {get {return this.GetID();}}
        private int?   id;
        private string name;

        public CalamityNPC(string name) {
            this.id   = null;
            this.name = name;
        }

        internal int? GetID() {
            if (! this.id.HasValue && boss_titles.calamity_mod != null && boss_titles.calamity_mod.TryFind<ModNPC>(this.name, out ModNPC entity)) {
                this.id = entity.Type;
            }
            return this.id;
        }

    }

}
