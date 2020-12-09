using System;
using System.Collections.Generic;
using System.Text;

namespace listMakingApp
{
    public class ListModel
    {
        /// <summary>
        /// Represents the list that contains lists
        /// lists is the list that contains items
        /// </summary>
        public List<ListsModel> Lists { get; set; } = new List<ListsModel>();

    }
}
