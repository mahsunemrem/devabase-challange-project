using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IEntity
    {
         Guid Id { get; set; }
         DateTime AddedDate { get; set; }
         DateTime? UpdatedDate { get; set; }
         
    }
}
