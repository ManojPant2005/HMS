using HMS.Model.DatabaseModel;
using HMS.Model.Response;

namespace HMS.Data
{
    public interface IDepartmentServiceData
    {
        Task<Department[]> GetAll();
        Task<StatusResponse<Department>> Create(Department data);
    }
}
