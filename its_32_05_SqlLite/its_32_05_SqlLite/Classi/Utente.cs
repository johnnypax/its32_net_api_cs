namespace its_32_05_SqlLite.Classi
{
    public class Utente
    {
        public int Id { get; set; }
        public string Nominativo { get; set; } = null!;
        public string CodFis { get; set; } = null!;
        public string? Email { get; set; }
    }
}
