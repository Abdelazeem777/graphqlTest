using graphqlTest.Models;

namespace graphqlTest.Data
{
    public class Subscription
    {
        [Topic]
        [Subscribe]
        public Superhero SubscribeSuperhero([EventMessage] Superhero superhero)
        {
            return superhero;
        }

    }
}