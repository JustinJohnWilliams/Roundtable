using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.DAL.Location.Database;
using Roundtable.DAL.Presenter.Database;
using Roundtable.DAL.Talk.Database;

namespace Roundtable.DAL
{
    internal class RtDataContext: DataContext
    {
        public RtDataContext(string connectionString): base(connectionString)
        {
            
        }

        internal Table<PresenterDto> Presenters { get { return GetTable<PresenterDto>(); } }
        internal Table<LocationDto> Locations { get { return GetTable<LocationDto>(); } }
        internal Table<TalkDto> Talks { get { return GetTable<TalkDto>(); } }
    }
}
