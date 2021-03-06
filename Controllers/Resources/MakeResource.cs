using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Angular_2___Asp_Net.Controllers.Resources
{
    public class MakeResource
    {
         public MakeResource()
        {
            Models = new Collection<ModelResource>();

        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set; }
    }
}