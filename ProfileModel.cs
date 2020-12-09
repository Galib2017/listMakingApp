using System;
using System.Collections.Generic;
using System.Text;

namespace listMakingApp
{
    public class ProfileModel
    {
        /// <summary>
        /// Represents the name of a profile
        /// </summary>
        public string ProfileName { get; set; }

        /// <summary>
        /// Represrnts the code to acsses the profile 
        /// </summary>
        public string ProfileCode { get; set; }

        /// <summary>
        /// Represents the lists this profile holdes 
        /// </summary>
        public List<ListModel> Profile { get; set; } = new List<ListModel>();
    }
}
