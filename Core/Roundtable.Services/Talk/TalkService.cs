using System;
using System.Collections.Generic;
using System.Linq;
using Roundtable.Contracts.Talk;
namespace Roundtable.Services.Talk
{
    public class TalkService: ITalkService
    {
        private readonly ITalkRetriever _talkRetriever;
        private readonly ITalkSaver _talkSaver;

        public TalkService(ITalkRetriever talkRetriever, ITalkSaver talkSaver)
        {
            _talkRetriever = talkRetriever;
            _talkSaver = talkSaver;
        }

        public List<IDetailedTalk> GetTalks()
        {
            return _talkRetriever.GetTalks();
        }

        public IDetailedTalk GetTalk(Guid id)
        {
            return _talkRetriever.GetTalks(t => t.TalkId == id).FirstOrDefault();
        }

        public Guid SaveTalk(ITalk talk)
        {
            return _talkSaver.SaveTalk(talk);
        }


        public void DeleteTalk(Guid talkId)
        {
            _talkSaver.DeleteTalk(talkId);
        }
    }
}