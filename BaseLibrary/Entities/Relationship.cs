using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.Json.Serialization;


namespace BaseLibrary.Entities
{
    public class Relationship
    {
        //Relationship : One to many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
