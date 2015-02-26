using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using CSM.OperationBed.DataTypes;

namespace CSM.Utilites
{
    public class XMLOperator
    {
        XmlReader _reader;
        string _characterName;
        string _path;
        string[] _files;

        public XMLOperator(string characterName)
        {
            _characterName = characterName;   
            _path = Directory.GetCurrentDirectory() + "\\Characters\\";
            
        }
         
        public List<ClassSkill> ReadSkills()
        {
            _reader = XmlReader.Create(_path + _characterName + ".xml");
            List<ClassSkill> skills = new List<ClassSkill>();
            ClassSkill skill;
            int buffer;
            while(_reader.ReadToFollowing("Skill"))
            {
                skill = new ClassSkill();
                _reader.MoveToFirstAttribute();
                skill.Name = _reader.Value;
                _reader.MoveToNextAttribute();
                skill.RelevantAttribute = _reader.Value;
                _reader.MoveToNextAttribute();
                Int32.TryParse(_reader.Value, out buffer);
                skill.Ranks = buffer;
                _reader.MoveToNextAttribute();
                Int32.TryParse(_reader.Value, out buffer);
                skill.MiscMod = buffer;
                skills.Add(skill);
            }
            
            return skills;
        }
        public List<ClassAttribute> ReadAttribute()
        {
            List<ClassAttribute> attributes = new List<ClassAttribute>();
            ClassAttribute attribute;
            int buffer;
            string fullPath = _path + _characterName + ".xml";
            _reader = XmlReader.Create(fullPath);
            while (_reader.ReadToFollowing("Attribute"))
            {
                attribute = new ClassAttribute();
                _reader.MoveToFirstAttribute();
                attribute.Name = _reader.Value;
                _reader.MoveToNextAttribute();
                attribute.Short = _reader.Value;
                _reader.MoveToNextAttribute();
                Int32.TryParse(_reader.Value,out buffer);
                attribute.Score = buffer;
                attributes.Add(attribute);
            }
            return attributes;
        }
        public List<SavingThrow> ReadSavings()
        {
            List<SavingThrow> savings = new List<SavingThrow>();
            SavingThrow saving;
            int buffer;
            _reader = XmlReader.Create(_path + _characterName + ".xml");
            
            while(_reader.ReadToFollowing("SavingThrow"))
            {
                saving = new SavingThrow();
                _reader.MoveToFirstAttribute();
                saving.Name = _reader.Value;
                _reader.MoveToNextAttribute();
                saving.RelevantAttribute = _reader.Value;
                _reader.MoveToNextAttribute();
                Int32.TryParse(_reader.Value, out buffer);
                saving.BaseSave = buffer;
                _reader.MoveToNextAttribute();
                Int32.TryParse(_reader.Value, out buffer);
                saving.MagicModifier = buffer;
                _reader.MoveToNextAttribute();
                Int32.TryParse(_reader.Value, out buffer);
                saving.MiscModifier = buffer;
                savings.Add(saving);
            }
            return savings;
        }

    }
}
