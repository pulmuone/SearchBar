using System;
using System.Collections.Generic;
using System.Text;

namespace App18
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Location { get; set; }

        public UserModel()
        {

        }
        public UserModel(string name, string id, string location)
        {
            this.Name = name;
            this.Id = id;
            this.Location = location;
        }
    }
}
