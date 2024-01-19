using HMS.Model.DatabaseModel;
using Microsoft.EntityFrameworkCore;


namespace HMS.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    

        #endregion

        #region Fields
        public  DbSet<Login> Logins { get; set; }
        public  DbSet<Department> Departments { get; set; }
        public  DbSet<Patient> Patients { get; set; }
        public  DbSet<Doctor> Doctors { get; set; }
        public  DbSet<Appointment> Appointments { get; set; }
        #endregion
    }
}
