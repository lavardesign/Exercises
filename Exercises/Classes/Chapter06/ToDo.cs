using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises.Classes.Chapter06
{
    public class ToDo
    {
        private string description = string.Empty;
        public bool completed = false;
        private Dictionary<string, object> checkboxAttributes = new Dictionary<string, object>();
        private Dictionary<string, object> descriptionAttributes = new Dictionary<string, object>();

        public ToDo(string description)
        {
            this.description = description;
        }

        public string GetDescription() => description;
        public Dictionary<string, object> GetCheckboxAttributes() => checkboxAttributes;
        public Dictionary<string, object> GetDescriptionAttributes() => descriptionAttributes;
        public void CheckAttributes()
        {
            completed = !completed;

            if (completed)
            {
                checkboxAttributes.Add("checked", "checked");
                descriptionAttributes.Add("class", "completed");
            }
            else
            {
                checkboxAttributes.Clear();
                descriptionAttributes.Clear();
            }
        }
    }
}
