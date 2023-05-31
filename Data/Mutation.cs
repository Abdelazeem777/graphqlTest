using graphqlTest.Models;
using HotChocolate.Subscriptions;
using SuperHeroApi.Data;
using graphqlTest.FakeDBNamespace;

namespace graphqlTest.Data
{
    public class Mutation
    {
        public async Task<string> AddSuperhero(
            // [Service] ApplicationDbContext context,
            [Service] ITopicEventSender eventSender,
            Superhero model
        )
        {
            // //Save to database
            // await context.Superheroes.AddAsync(model);
            // await context.SaveChangesAsync();

            FakeDB.MySuperHerosFakeDB.Add(model);

            await eventSender.SendAsync(nameof(Subscription.SubscribeSuperhero), model);
            return model.Name;
        }

    }
}