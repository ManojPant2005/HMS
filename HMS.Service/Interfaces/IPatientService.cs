using HMS.Model.DatabaseModel;

namespace HMS.Service.Interfaces
{
    public interface IPatientService
    {
        Task<Patient> Insert(Patient patient);
        Task<Patient> GetByEmailId(string id);
        Task<IEnumerable<Patient>> GetAllByDocId(string Id);
        Task<Patient> GetById(string Id);
        Task<Patient> Update(Patient patient);
        Task<int> TotalCount();
        Task<IEnumerable<Patient>> GetAll();
    }

}
