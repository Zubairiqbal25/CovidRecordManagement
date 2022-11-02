//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Covid.Entities;
//using static Covid.Entities.Entities;

//namespace Covid.DAL.Context
//{
//    public partial class ApplicationDbContext : DbContext
//    {
//        private readonly IConfiguration _configuration;
//        public ApplicationDbContext(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }
//        public ApplicationDbContext(DbContextOptions<DbContext> options)
//            : base(options)
//        {

//        }
//        public virtual DbSet<Patient> Patient { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                optionsBuilder.UseSqlServer(_configuration.GetSection("ConnectionStrings").Get<Connection>().DefaultConnection);
//            }
//        }

//    }
//}
