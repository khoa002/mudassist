using ff14bot;
using ff14bot.Enums;
using ff14bot.Objects;

namespace Mud.Helpers
{
    public class JobHelper
    {
        #region Stats

        public static readonly string AMP = Core.Player.Stats.AttackMagicPotency.ToString();
        public static readonly string ATK = Core.Player.Stats.AttackPower.ToString();
        public static readonly string CRIT = Core.Player.Stats.CriticalHit.ToString();
        public static readonly string CSM = Core.Player.Stats.Craftsmanship.ToString();
        public static readonly string CTL = Core.Player.Stats.Control.ToString();
        public static readonly string CURCP = Core.Player.CurrentCP.ToString();
        public static readonly string CURCPPERC = Core.Player.CurrentCPPercent.ToString("0.#");
        public static readonly string CURGP = Core.Player.CurrentGP.ToString();
        public static readonly string CURGPPERC = Core.Player.CurrentGPPercent.ToString("0.#");
        public static readonly string CURHP = Core.Player.CurrentHealth.ToString();
        public static readonly string CURHPPERC = Core.Player.CurrentHealthPercent.ToString("0.#");
        public static readonly string CURMP = Core.Player.CurrentMana.ToString();
        public static readonly string CURMPPERC = Core.Player.CurrentManaPercent.ToString("0.#");
        public static readonly string CURTP = Core.Player.CurrentTP.ToString();
        public static readonly string CURTPPERC = Core.Player.CurrentCPPercent.ToString("0.#");
        public static readonly string DEF = Core.Player.Stats.Defense.ToString();
        public static readonly string DEX = Core.Player.Stats.Dexterity.ToString();
        public static readonly string DHIT = Core.Player.Stats.DirectHitRate.ToString();
        public static readonly string EARTH = Core.Player.Stats.Earth.ToString();
        public static readonly string FIRE = Core.Player.Stats.Fire.ToString();
        public static readonly string GTH = Core.Player.Stats.Gathering.ToString();
        public static readonly string HMP = Core.Player.Stats.HealingMagicPotency.ToString();
        public static readonly string ICE = Core.Player.Stats.Ice.ToString();
        public static readonly string INT = Core.Player.Stats.Intelligence.ToString();
        public static readonly string JOB = Core.Player.CurrentJob.ToString();
        public static readonly string LEVEL = Core.Player.ClassLevel.ToString();
        public static readonly string LIGHTINING = Core.Player.Stats.Lightning.ToString();
        public static readonly string MAXCP = Core.Player.MaxCP.ToString();
        public static readonly string MAXGP = Core.Player.MaxGP.ToString();
        public static readonly string MAXHP = Core.Player.MaxHealth.ToString();
        public static readonly string MAXMP = Core.Player.MaxMana.ToString();
        public static readonly string MAXTP = Core.Player.MaxTP.ToString();
        public static readonly string MDEF = Core.Player.Stats.MagicDefense.ToString();
        public static readonly string MND = Core.Player.Stats.Mind.ToString();
        public static readonly string MSPD = Core.Player.Stats.SpellSpeed.ToString();
        public static readonly string NAME = Core.Player.Name;
        public static readonly string PRT = Core.Player.Stats.Perception.ToString();
        public static readonly string PSPD = Core.Player.Stats.SkillSpeed.ToString();
        public static readonly string PTY = Core.Player.Stats.Piety.ToString();
        public static readonly string STR = Core.Player.Stats.Strength.ToString();
        public static readonly string TNC = Core.Player.Stats.Tenacity.ToString();
        public static readonly string VIT = Core.Player.Stats.Vitality.ToString();
        public static readonly string WATER = Core.Player.Stats.Water.ToString();
        public static readonly string WIND = Core.Player.Stats.Wind.ToString();

        #endregion Stats

        #region Job Types

        public static bool IsDoH(Character c)
        {
            switch (c.CurrentJob)
            {
                case ClassJobType.Alchemist:
                case ClassJobType.Armorer:
                case ClassJobType.Blacksmith:
                case ClassJobType.Carpenter:
                case ClassJobType.Culinarian:
                case ClassJobType.Goldsmith:
                case ClassJobType.Leatherworker:
                case ClassJobType.Weaver:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsDoL(Character c)
        {
            switch (c.CurrentJob)
            {
                case ClassJobType.Botanist:
                case ClassJobType.Fisher:
                case ClassJobType.Miner:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsHealer(Character c)
        {
            switch (c.CurrentJob)
            {
                case ClassJobType.Astrologian:
                case ClassJobType.Conjurer:
                case ClassJobType.Scholar:
                case ClassJobType.WhiteMage:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsMeleeDPS(Character c)
        {
            switch (c.CurrentJob)
            {
                case ClassJobType.Dragoon:
                case ClassJobType.Lancer:
                case ClassJobType.Monk:
                case ClassJobType.Ninja:
                case ClassJobType.Pugilist:
                case ClassJobType.Rogue:
                case ClassJobType.Samurai:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsRangedDPS(Character c)
        {
            switch (c.CurrentJob)
            {
                case ClassJobType.Arcanist:
                case ClassJobType.Archer:
                case ClassJobType.Bard:
                case ClassJobType.BlackMage:
                case ClassJobType.Machinist:
                case ClassJobType.RedMage:
                case ClassJobType.Summoner:
                case ClassJobType.Thaumaturge:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsTank(Character c)
        {
            switch (c.CurrentJob)
            {
                case ClassJobType.DarkKnight:
                case ClassJobType.Gladiator:
                case ClassJobType.Paladin:
                case ClassJobType.Marauder:
                case ClassJobType.Warrior:
                    return true;

                default:
                    return false;
            }
        }

        #endregion Job Types
    }
}