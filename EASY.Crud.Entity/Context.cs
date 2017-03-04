using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EASY.Crud.Entity.Model;

namespace EASY.Crud.Entity
{
    public class Context : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<KnowledgeBase> KnowledgeBase { get; set; }
        public DbSet<BankInfo> BankInfo { get; set; }
        
    }
}

