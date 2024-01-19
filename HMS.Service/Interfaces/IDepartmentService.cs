using HMS.Model.DatabaseModel;

namespace HMS.Service.Interfaces
{
    public interface IDepartmentService
    {
        Task<Department> Insert(Department doctor);
        Task<IEnumerable<Department>> GetAll();
    }
}
