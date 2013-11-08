using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Talk;
using Roundtable.DAL.Talk.Database;

namespace Roundtable.DAL.Talk
{
    public class TalkRepository: ITalkRetriever, ITalkSaver
    {
        private readonly string _connectionString;

        public TalkRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<IDetailedTalk> GetTalks(Func<IDetailedTalk, bool> whereClause = null)
        {
            using (var db = new RtDataContext(_connectionString))
            {
                var talks = whereClause == null ? db.DetailedTalks : db.DetailedTalks.Where(whereClause);

                return talks.ToList();
            }
        }

        public Guid SaveTalk(ITalk talk)
        {
            using (var db = new RtDataContext(_connectionString))
            {
                var dto = db.Talks.FirstOrDefault(t => t.TalkId == talk.TalkId);

                if (dto == null || talk.TalkId == Guid.Empty)
                {
                    dto = new TalkDto() { TalkId = Guid.NewGuid() };

                    db.Talks.InsertOnSubmit(dto);
                }

                dto.LocationId = talk.LocationId;
                dto.PresenterId = talk.PresenterId;
                dto.Topic = talk.Topic;

                db.SubmitChanges();

                return dto.TalkId;

            }
        }
    }
}
