using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Entity :IEntity
    {
        public Guid Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
