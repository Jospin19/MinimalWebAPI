namespace MinimalWebAPI.Services
{
    public record User(int Id, string Name);

    ////Equivaut a la déclaration précédente
    //public record User
    //{
    //    public int Id { get; init; } = default!;

    //    public string name { get; set; }
    //}

    ////Si on veut permettre d'initialiser son setter mais seulement a l'initialisation
    //public record User
    //{
    //    public int Id { get; set; } = default!;

    //    public string name { get; set; }
    //}

    public class UserService
    {
        public Task<List<User>> GetAll()
        {
            var list = new List<User>()
            {
                new User(1, "Hugo")
            };

            return Task.FromResult(list);
        }
    }
}
