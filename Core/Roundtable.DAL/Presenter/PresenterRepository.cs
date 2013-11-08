using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Presenter;
using Roundtable.DAL.Presenter.Database;

namespace Roundtable.DAL.Presenter
{
    public class PresenterRepository: IPresenterSaver, IPresenterRetriever
    {
        private readonly string _connectionString;

        public PresenterRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Guid SavePresenter(IPresenter presenter)
        {
            using (var db = new RtDataContext(_connectionString))
            {
                var dto = db.Presenters.FirstOrDefault(p => p.Id == presenter.Id);

                if (dto == null)
                {
                    dto = new PresenterDto() {Id = Guid.NewGuid() };

                    db.Presenters.InsertOnSubmit(dto);
                }

                dto.FirstName = presenter.FirstName;
                dto.LastName = presenter.LastName;

                db.SubmitChanges();

                return dto.Id;
            }
        }

        public List<IPresenter> GetPresenters(Func<IPresenter, bool> whereClause)
        {
            using (var db = new RtDataContext(_connectionString))
            {
                return db.Presenters.Where(whereClause).ToList();
            }
        }


        public List<IPresenter> GetPresenters()
        {
            using (var db = new RtDataContext(_connectionString))
            {
                return db.Presenters.Cast<IPresenter>().ToList();
            }
        }
    }
}
