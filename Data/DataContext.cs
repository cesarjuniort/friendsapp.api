using Microsoft.EntityFrameworkCore;

namespace FriendsApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){            
        }
    }
}