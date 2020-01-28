using System;
using System.Collections.Generic;
using System.Text;
using WandaPlusTv.Application.Contracts;
using WandaPlusTv.Data.Contracts;

namespace WandaPlusTv.Application
{
    public class AdministrationLogic : IAdministrationLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdministrationLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IUnitOfWork UnitOfWork => _unitOfWork;
    }
}
