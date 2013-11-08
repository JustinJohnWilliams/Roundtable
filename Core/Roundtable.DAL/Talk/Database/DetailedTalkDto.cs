using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Talk;

namespace Roundtable.DAL.Talk.Database
{
    [Table(Name="dbo.vw_Talks")]
    internal class DetailedTalkDto: IDetailedTalk
    {
        [Column]
        public Guid TalkId { get; set; }
        
        [Column]
        public string Topic { get; set; }
        
        [Column]
        public Guid PresenterId { get; set; }

        [Column]
        public Guid LocationId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }
    }
}
