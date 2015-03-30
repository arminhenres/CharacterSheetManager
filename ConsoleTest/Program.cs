using CSM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Character chara = new Character();

            chara.Name = "Taraliel";
            chara.Level = 14;
            chara.HitPoints = 150;
            chara.BaseAttackBonus = 14;

            chara.Strength = new ClassAttribute { Name = "Strength", Score = 18 };
            chara.Dexterity = new ClassAttribute { Name = "Dexterity", Score = 19 };
            chara.Constitution = new ClassAttribute { Name = "Constitution", Score = 15 };
            chara.Intelligence = new ClassAttribute { Name = "Intelligence", Score = 13 };
            chara.Wisdom = new ClassAttribute { Name = "Wisdom", Score = 12 };
            chara.Charisma = new ClassAttribute { Name = "Charisma", Score = 8 };

            var settings = new XmlWriterSettings();
            settings.Indent = true;
            

            XmlWriter writer = XmlWriter.Create("C:\\Users\\Armin\\Documents\\CharSheetGenerator\\CharacterTest.xml", settings);

            chara.WriteXml(writer);
        }
    }
}
