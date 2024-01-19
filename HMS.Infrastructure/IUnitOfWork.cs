using HMS.Model.DatabaseModel;

namespace HMS.Infrastructure
{
    public interface IUnitOfWork
    {
        IGenericRepository<Login> Logins { get; }
        IGenericRepository<Department> Departments { get; }
        IGenericRepository<Patient> Patients { get; }
        IGenericRepository<Doctor> Doctors { get; }
        IGenericRepository<Appointment> Appointments { get; }
        Task<bool> CompleteAsync();
        void Dispose();
    }
}
