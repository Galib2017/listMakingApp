using System;
using System.Collections.Generic;
using System.Text;

namespace listMakingApp
{
    public class ListsModel
    {
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();
        public string ListTitle { get; set; }
    }
}
