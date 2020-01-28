using System;
using System.Collections.Generic;
using System.Text;
using WandaPlusTv.Data.Contracts;

namespace WandaPlusTv.Application.Contracts
{
    public interface IAdministrationLogic
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
