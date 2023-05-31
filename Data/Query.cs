using graphqlTest.Models;
using SuperHeroApi.Data;
using graphqlTest.FakeDBNamespace;

namespace graphqlTest.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        // public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
        //    context.Superheroes;
        public IQueryable<Superhero> GetSuperheroes() =>
           FakeDB.MySuperHerosFakeDB.AsQueryable();


    }

}