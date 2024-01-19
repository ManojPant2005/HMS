using HMS.Model.DatabaseModel;

namespace HMS.Service.Interfaces
{
    public interface IDoctorService
    {
        Task<Doctor> Insert(Doctor doctor);
        Task<Doctor> Update(Doctor doctor);

        Task<Doctor> GetById(string id);
        Task<IEnumerable<Doctor>> GetAll();
        Task<Doctor> GetByEmailId(string id);
        Task<IEnumerable<Doctor>> GetByDepartment(int id);
        Task<int> TotalCount();
    }
}
