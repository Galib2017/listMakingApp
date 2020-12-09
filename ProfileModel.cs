using System;
using System.Collections.Generic;
using System.Text;

namespace listMakingApp
{
    public class ProfileModel
    {
        public string ProfileName { get; set; }
        public string ProfileCode { get; set; }
        public List<ListModel> Profile { get; set; }
    }
}
