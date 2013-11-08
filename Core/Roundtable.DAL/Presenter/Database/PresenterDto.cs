﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roundtable.Contracts.Presenter;

namespace Roundtable.DAL.Presenter.Database
{
    [Table(Name="Presenters")]
    internal class PresenterDto: IPresenter
    {
        [Column(IsPrimaryKey = true)]
        public Guid Id { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }
    }
}
