using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public bool IsDeleted { get; set; }= false;
    }
}
