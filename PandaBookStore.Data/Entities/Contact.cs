using PandaBookStore.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PandaBookStore.Data.Entities
{
    public class Contact : BaseEntity
    {
     
        public string EmailAddress { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        
    }
}
