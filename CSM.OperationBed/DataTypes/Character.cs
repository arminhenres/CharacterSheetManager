using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.OperationBed.DataTypes
{
    class Character
    {
        #region MainProperties
        public string Name
        {
            get;
            set;
        }

        public int Level
        {
            get;
            set;
        }

        public int HitPoints
        {
            get;
            set;
        }

        public int BaseAttackBonus
        {
            get;
            set;
        }
        #endregion

        #region Attributes
        public ClassAttribute Strength
        {
            get;
            set;
        }

        public ClassAttribute Dexterity
        {
            get;
            set;
        }

        public ClassAttribute Constitution
        {
            get;
            set;
        }

        public ClassAttribute Intelligence
        {
            get;
            set;
        }

        public ClassAttribute Wisdom
        {
            get;
            set;
        }

        public ClassAttribute Charisma
        {
            get;
            set;
        }


        #endregion

        #region Others
        public Weapon WeaponEquipped
        {
            get;
            set;
        }

        public List<AcItem> AcItemsEquipped
        {
            get;
            set;
        }

        public List<Item> Inventory
        {
            get;
            set;
        }

        public List<Feat> Feats
        {
            get;
            set;
        }

        public List<ClassSkill> Skills
        {
            get;
            set;
        }

        public int InitiativeMisc
        {
            get;
            set;
        }

        public int NaturalArmor
        {
            get;
            set;
        }

        public List<SavingThrow> SavingThrows
        {
            get;
            set;
        }

        public int SizeModifier
        {
            get;
            set;
        }

        public List<SpecialAbility> SpecialAbilities
        {
            get;
            set;
        }

        public List<Spell> Spells
        {
            get;
            set;
        }
        #endregion

        #region Calculated
        public int ArmorClass
        {
            get
            {
                int ac = 10;
                foreach (AcItem acItem in AcItemsEquipped)
                {
                    ac += acItem.Bonus;
                }
                ac += Dexterity.Modifier;
                ac += SizeModifier;
                ac += NaturalArmor;
                return ac;
            }
        }

        public int ACFlatFooted
        {
            get
            {
                return ArmorClass - Dexterity.Modifier;
            }
        }

        public int ACTouch
        {
            get
            {
                int ac = 0;

                foreach (AcItem acItem in AcItemsEquipped)
                {
                    ac += acItem.Bonus;
                }
                return ArmorClass - ac;
            }
        }

        public int CMB
        {
            get
            {
                int cmb = BaseAttackBonus;
                cmb += Strength.Modifier;
                cmb += SizeModifier;
                return cmb;
            }
        }

        public int CMD
        {
            get
            {
                int cmd = 10;
                cmd += BaseAttackBonus;
                cmd += Strength.Modifier;
                cmd += Dexterity.Modifier;
                cmd += SizeModifier;
                return cmd;
            }
        }
        #endregion

    }
}
