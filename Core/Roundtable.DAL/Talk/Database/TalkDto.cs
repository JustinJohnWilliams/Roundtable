using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Talk;

namespace Roundtable.DAL.Talk.Database
{
    [Table(Name="Talks")]
    internal class TalkDto: ITalk
    {
        [Column(IsPrimaryKey = true)]
        public Guid Id { get; set; }

        [Column]
        public string Topic { get; set; }
        
        [Column]
        public Guid PresenterId { get; set; }
        
        [Column]
        public Guid LocationId { get; set; }
    }
}
