using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMF_Simplifier
{
    public class SaveMapHead
    {
        public int ExeVersion;

        public int SaveVersion;

        public int CreatedVersion;

        public string MapName;

        public string OwnerGamerTag;

        public long DateCreated;

        public long DateSaved;

        public bool IsAutoSave;

        public int MapSeed;

        public int GameType;

        public bool GoodHash = true;

        public bool PvPCombat = true;

        public bool CombatEnabled;

        public bool FiniteMode;

        public bool PassiveMobs;

        public bool EnemyMobs;

        public bool KeepItemsOnDeath;

        public bool DayNightActive;

        public bool WeatherActive;

        public bool ClanProtection;

        public float WindFactor;

        public int DaysIntoGame;

        public int HoursSlept;

        public int UnusedInt1;

        public byte UnusedByte1;

        public int DepthReached;

        public float RatingStars;

        public int RatingCount;

        public bool SkillsEnabled;

        public bool SkillsLocal;

        public float XPMultiplier = 1f;

        public string TexturePack = "Original HD";

        public int MaxPlayers;

        public int PrivateSlots;

        public short CombatLevelDifference;

        public List<string> ModNames;
        

        public bool Pre18
        {
            get
            {
                return CreatedVersion < 58;
            }
        }

        public SaveMapHead Clone()
        {
            SaveMapHead saveMapHead = new SaveMapHead();
            saveMapHead.ExeVersion = ExeVersion;
            saveMapHead.SaveVersion = SaveVersion;
            saveMapHead.CreatedVersion = CreatedVersion;
            saveMapHead.MapName = MapName;
            saveMapHead.OwnerGamerTag = OwnerGamerTag;
            saveMapHead.DateCreated = DateCreated;
            saveMapHead.DateSaved = DateSaved;
            saveMapHead.IsAutoSave = IsAutoSave;
            saveMapHead.MapSeed = MapSeed;
            saveMapHead.GameType = GameType;
            saveMapHead.PvPCombat = PvPCombat;
            saveMapHead.CombatEnabled = CombatEnabled;
            saveMapHead.FiniteMode = FiniteMode;
            saveMapHead.PassiveMobs = PassiveMobs;
            saveMapHead.EnemyMobs = EnemyMobs;
            saveMapHead.KeepItemsOnDeath = KeepItemsOnDeath;
            saveMapHead.DayNightActive = DayNightActive;
            saveMapHead.WeatherActive = WeatherActive;
            saveMapHead.WindFactor = WindFactor;
            saveMapHead.DaysIntoGame = DaysIntoGame;
            saveMapHead.HoursSlept = HoursSlept;
            saveMapHead.UnusedInt1 = UnusedInt1;
            saveMapHead.DepthReached = DepthReached;
            saveMapHead.RatingStars = RatingStars;
            saveMapHead.RatingCount = RatingCount;
            saveMapHead.SkillsEnabled = SkillsEnabled;
            saveMapHead.SkillsLocal = SkillsLocal;
            saveMapHead.XPMultiplier = XPMultiplier;
            saveMapHead.UnusedInt1 = UnusedInt1;
            saveMapHead.UnusedByte1 = UnusedByte1;
            saveMapHead.TexturePack = TexturePack;
            saveMapHead.MaxPlayers = MaxPlayers;
            saveMapHead.PrivateSlots = PrivateSlots;
            saveMapHead.CombatLevelDifference = CombatLevelDifference;
            saveMapHead.ClanProtection = ClanProtection;
            if (ModNames != null && ModNames.Count > 0)
            {
                saveMapHead.ModNames = new List<string>(ModNames);
            }
            return saveMapHead;
        }
        
    }
}
