using System;
using System.Collections.Generic;
using System.Text;

namespace Lists.Model
{
    public class GroupContact : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public GroupContact(string title, string shortTitle)
        {
            title = Title;
            shortTitle = ShortTitle;
        }
    }
}
