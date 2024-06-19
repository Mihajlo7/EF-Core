using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
