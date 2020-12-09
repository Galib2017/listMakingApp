using System;
using System.Collections.Generic;
using System.Text;

namespace listMakingApp
{
    public class ItemModel
    {
        /// <summary>
        /// Represents the items name basicaly the item
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// Reperesents the list number or
        /// the posisition of the item in the list
        /// </summary>
        public int ItemNo { get; set; }
        /// <summary>
        /// This is suppose to make the items not have the 
        /// same seirial number
        /// </summary>
        /// <param name="ItemNo">
        /// Represents the item serial number
        /// </param>
        public ItemModel (int ItemNo)
        { 
           
        }
    }
}
