using ff14bot;
using ff14bot.Enums;
using ff14bot.Objects;

namespace Mud.Helpers
{
    public static class JobHelper
    {
        #region Stats

        public static readonly string Amp = Core.Player.Stats.AttackMagicPotency.ToString();
        public static readonly string Atk = Core.Player.Stats.AttackPower.ToString();
        public static readonly string Crit = Core.Player.Stats.CriticalHit.ToString();
        public static readonly string Csm = Core.Player.Stats.Craftsmanship.ToString();
        public static readonly string Ctl = Core.Player.Stats.Control.ToString();
        public static readonly string Curcp = Core.Player.CurrentCP.ToString();
        public static readonly string Curcpperc = Core.Player.CurrentCPPercent.ToString("0.#");
        public static readonly string Curgp = Core.Player.CurrentGP.ToString();
        public static readonly string Curgpperc = Core.Player.CurrentGPPercent.ToString("0.#");
        public static readonly string Curhp = Core.Player.CurrentHealth.ToString();
        public static readonly string Curhpperc = Core.Player.CurrentHealthPercent.ToString("0.#");
        public static readonly string Curmp = Core.Player.CurrentMana.ToString();
        public static readonly string Curmpperc = Core.Player.CurrentManaPercent.ToString("0.#");
        public static readonly string Curtp = Core.Player.CurrentTP.ToString();
        public static readonly string Curtpperc = Core.Player.CurrentCPPercent.ToString("0.#");
        public static readonly string Def = Core.Player.Stats.Defense.ToString();
        public static readonly string Dex = Core.Player.Stats.Dexterity.ToString();
        public static readonly string Dhit = Core.Player.Stats.DirectHitRate.ToString();
        public static readonly string Earth = Core.Player.Stats.Earth.ToString();
        public static readonly string Fire = Core.Player.Stats.Fire.ToString();
        public static readonly string Gth = Core.Player.Stats.Gathering.ToString();
        public static readonly string Hmp = Core.Player.Stats.HealingMagicPotency.ToString();
        public static readonly string Ice = Core.Player.Stats.Ice.ToString();
        public static readonly string Int = Core.Player.Stats.Intelligence.ToString();
        public static readonly string Job = Core.Player.CurrentJob.ToString();
        public static readonly string Level = Core.Player.ClassLevel.ToString();
        public static readonly string Lightining = Core.Player.Stats.Lightning.ToString();
        public static readonly string Maxcp = Core.Player.MaxCP.ToString();
        public static readonly string Maxgp = Core.Player.MaxGP.ToString();
        public static readonly string Maxhp = Core.Player.MaxHealth.ToString();
        public static readonly string Maxmp = Core.Player.MaxMana.ToString();
        public static readonly string Maxtp = Core.Player.MaxTP.ToString();
        public static readonly string Mdef = Core.Player.Stats.MagicDefense.ToString();
        public static readonly string Mnd = Core.Player.Stats.Mind.ToString();
        public static readonly string Mspd = Core.Player.Stats.SpellSpeed.ToString();
        public static readonly string Name = Core.Player.Name;
        public static readonly string Prt = Core.Player.Stats.Perception.ToString();
        public static readonly string Pspd = Core.Player.Stats.SkillSpeed.ToString();
        public static readonly string Pty = Core.Player.Stats.Piety.ToString();
        public static readonly string Str = Core.Player.Stats.Strength.ToString();
        public static readonly string Tnc = Core.Player.Stats.Tenacity.ToString();
        public static readonly string Vit = Core.Player.Stats.Vitality.ToString();
        public static readonly string Water = Core.Player.Stats.Water.ToString();
        public static readonly string Wind = Core.Player.Stats.Wind.ToString();

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

        public static bool IsMeleeDps(Character c)
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

        public static bool IsRangedDps(Character c)
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