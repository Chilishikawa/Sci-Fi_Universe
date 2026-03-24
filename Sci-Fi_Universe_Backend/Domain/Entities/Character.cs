namespace Domain.Entities
{
    // IMPORTANTE:
    // Esta clase No debe depender de nada externo (ni EF, ni ASP.NET, nada)
    // Es el corazón del negocio
    public class Character
    {
        // public int Id { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
        public string Work { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
