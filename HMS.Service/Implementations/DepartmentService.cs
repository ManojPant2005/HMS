using HMS.Infrastructure;
using HMS.Model.DatabaseModel;
using HMS.Service.Interfaces;

namespace HMS.Service.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public DepartmentService(IUnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }
        #endregion

        #region Methods
        public async Task<Department> Insert(Department doctor)
        {
            try
            {
                var result = await _unitOfWork.Departments.AddData(doctor);
                var resultcheck = await _unitOfWork.CompleteAsync();
                return await Task.Run(() => resultcheck ? result : null);
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Department>> GetAll()
        {
            try
            {
                return await _unitOfWork.Departments.GetData();
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
