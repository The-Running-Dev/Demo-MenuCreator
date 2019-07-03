using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MenuCreator.Library
{
    public class MenuItem : Menu
    {
        public int Level { get; private set; }

        public List<MenuItem> SubItems { get; set; }

        public MenuItem(string name = null, int level = 0) : base(name)
        {
            Level = level;
            Name = name;
            SubItems = new List<MenuItem>();
        }

        public void Add(string name)
        {
            Add(new MenuItem(name));
        }

        public void Add(MenuItem item)
        {
            item.Level = Level + 1;

            SubItems.Add(item);

            AdjustLevel(item, item.Level);
        }

        private void AdjustLevel(MenuItem item, int currentLevel)
        {
            foreach (var i in item.SubItems)
            {
                AdjustLevel(i, currentLevel + 1);
            }

            item.Level = currentLevel;
        }

        public void AddTo(string name, string subName)
        {
            AddTo(name, new MenuItem(subName));
        }

        public void AddTo(string name, MenuItem item)
        {
            Child(name)?.Add(item);
        }

        public MenuItem Child(string name)
        {
            if (string.Compare(Name, name, StringComparison.InvariantCultureIgnoreCase) == 0)
            {
                return this;
            }

            foreach (var item in SubItems)
            {
                return item.Child(name);
            }

            return null;
        }

        public string Generate(string separator)
        {
            var stringBuilder = new StringBuilder();
            var indent = "";

            // Figure out how much to indent
            for (var i = 1; i < Level; i++)
            {
                indent += "\t";
            }

            if (!string.IsNullOrEmpty(indent))
            {
                // Append name with the indent
                stringBuilder.AppendFormat("{0} - {1}{2}", indent, Name, separator);
            }
            else
            {
                stringBuilder.AppendFormat("{0}{1}", Name, separator);
            }

            // If there are sub items
            if (SubItems.Any())
            {
                foreach (var subItem in SubItems)
                {
                    Level += 1;

                    stringBuilder.Append(subItem.Generate(separator));

                    Level -= 1;
                }
            }

            return stringBuilder.ToString();
        }
    }
}