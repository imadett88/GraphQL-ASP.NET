using GraphqlWithAsp.Data;
using GraphqlWithAsp.Models;

namespace GraphqlWithAsp.GraphQL
{
    public class Query
    {
        private readonly AppDbContext dbContext;

        public Query(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<User> Users => dbContext.Users;
    }
}
