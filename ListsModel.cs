using System;
using System.Collections.Generic;
using System.Text;

namespace listMakingApp
{
    public class ListsModel
    {
        /// <summary>
        /// Represents the the items in the list
        /// </summary>
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();
        /// <summary>
        /// Represents the title of the list
        /// </summary>
        public string ListTitle { get; set; }
         
    }
}
