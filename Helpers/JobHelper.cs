using ff14bot;
using ff14bot.Enums;
using ff14bot.Objects;

namespace Mud.Helpers
{
    public static class JobHelper
    {
        #region Stats

        public static readonly string Amp = Core.Player.Stats.AttackMagicPotency.ToString(),
            Atk = Core.Player.Stats.AttackPower.ToString(),
            Crit = Core.Player.Stats.CriticalHit.ToString(),
            Csm = Core.Player.Stats.Craftsmanship.ToString(),
            Ctl = Core.Player.Stats.Control.ToString(),
            Curcp = Core.Player.CurrentCP.ToString(),
            Curcpperc = Core.Player.CurrentCPPercent.ToString("0.#"),
            Curgp = Core.Player.CurrentGP.ToString(),
            Curgpperc = Core.Player.CurrentGPPercent.ToString("0.#"),
            Curhp = Core.Player.CurrentHealth.ToString(),
            Curhpperc = Core.Player.CurrentHealthPercent.ToString("0.#"),
            Curmp = Core.Player.CurrentMana.ToString(),
            Curmpperc = Core.Player.CurrentManaPercent.ToString("0.#"),
            Curtp = Core.Player.CurrentTP.ToString(),
            Curtpperc = Core.Player.CurrentCPPercent.ToString("0.#"),
            Def = Core.Player.Stats.Defense.ToString(),
            Dex = Core.Player.Stats.Dexterity.ToString(),
            Dhit = Core.Player.Stats.DirectHitRate.ToString(),
            Gth = Core.Player.Stats.Gathering.ToString(),
            Hmp = Core.Player.Stats.HealingMagicPotency.ToString(),
            Int = Core.Player.Stats.Intelligence.ToString(),
            Job = Core.Player.CurrentJob.ToString(),
            Level = Core.Player.ClassLevel.ToString(),
            Maxcp = Core.Player.MaxCP.ToString(),
            Maxgp = Core.Player.MaxGP.ToString(),
            Maxhp = Core.Player.MaxHealth.ToString(),
            Maxmp = Core.Player.MaxMana.ToString(),
            Maxtp = Core.Player.MaxTP.ToString(),
            Mdef = Core.Player.Stats.MagicDefense.ToString(),
            Mnd = Core.Player.Stats.Mind.ToString(),
            Mspd = Core.Player.Stats.SpellSpeed.ToString(),
            Name = Core.Player.Name,
            Prt = Core.Player.Stats.Perception.ToString(),
            Pspd = Core.Player.Stats.SkillSpeed.ToString(),
            Pty = Core.Player.Stats.Piety.ToString(),
            Str = Core.Player.Stats.Strength.ToString(),
            Tnc = Core.Player.Stats.Tenacity.ToString(),
            Vit = Core.Player.Stats.Vitality.ToString();

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