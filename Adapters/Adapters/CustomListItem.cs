﻿namespace Adapters
{
    public class CustomListItem
    {
        public string title { get; set; }
        public string description { get; set; }

        public CustomListItem(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
        
    }
}