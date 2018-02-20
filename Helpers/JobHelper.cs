using ff14bot;
using ff14bot.Enums;
using ff14bot.Objects;

namespace Mud.Helpers
{
    internal static class JobHelper
    {
        #region Stats

        public static readonly string Amp = Core.Me.Stats.AttackMagicPotency.ToString(),
            Atk = Core.Me.Stats.AttackPower.ToString(),
            Crit = Core.Me.Stats.CriticalHit.ToString(),
            Csm = Core.Me.Stats.Craftsmanship.ToString(),
            Ctl = Core.Me.Stats.Control.ToString(),
            Curcp = Core.Me.CurrentCP.ToString(),
            Curcpperc = Core.Me.CurrentCPPercent.ToString("0.#"),
            Curgp = Core.Me.CurrentGP.ToString(),
            Curgpperc = Core.Me.CurrentGPPercent.ToString("0.#"),
            Curhp = Core.Me.CurrentHealth.ToString(),
            Curhpperc = Core.Me.CurrentHealthPercent.ToString("0.#"),
            Curmp = Core.Me.CurrentMana.ToString(),
            Curmpperc = Core.Me.CurrentManaPercent.ToString("0.#"),
            Curtp = Core.Me.CurrentTP.ToString(),
            Curtpperc = Core.Me.CurrentCPPercent.ToString("0.#"),
            Def = Core.Me.Stats.Defense.ToString(),
            Dex = Core.Me.Stats.Dexterity.ToString(),
            Dhit = Core.Me.Stats.DirectHitRate.ToString(),
            Gth = Core.Me.Stats.Gathering.ToString(),
            Hmp = Core.Me.Stats.HealingMagicPotency.ToString(),
            Int = Core.Me.Stats.Intelligence.ToString(),
            Job = Core.Me.CurrentJob.ToString(),
            Level = Core.Me.ClassLevel.ToString(),
            Maxcp = Core.Me.MaxCP.ToString(),
            Maxgp = Core.Me.MaxGP.ToString(),
            Maxhp = Core.Me.MaxHealth.ToString(),
            Maxmp = Core.Me.MaxMana.ToString(),
            Maxtp = Core.Me.MaxTP.ToString(),
            Mdef = Core.Me.Stats.MagicDefense.ToString(),
            Mnd = Core.Me.Stats.Mind.ToString(),
            Mspd = Core.Me.Stats.SpellSpeed.ToString(),
            Name = Core.Me.Name,
            Prt = Core.Me.Stats.Perception.ToString(),
            Pspd = Core.Me.Stats.SkillSpeed.ToString(),
            Pty = Core.Me.Stats.Piety.ToString(),
            Str = Core.Me.Stats.Strength.ToString(),
            Tnc = Core.Me.Stats.Tenacity.ToString(),
            Vit = Core.Me.Stats.Vitality.ToString();

#if RB_CN
        public static readonly string Earth = Core.Me.Stats.Earth.ToString(),
            Fire = Core.Me.Stats.Fire.ToString(),
            Ice = Core.Me.Stats.Ice.ToString(),
            Lightining = Core.Me.Stats.Lightning.ToString(),
            Water = Core.Me.Stats.Water.ToString(),
            Wind = Core.Me.Stats.Wind.ToString();
#endif

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