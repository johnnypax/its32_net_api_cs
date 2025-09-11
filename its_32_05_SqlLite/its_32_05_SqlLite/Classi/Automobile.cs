namespace its_32_05_SqlLite.Classi
{
    public class Automobile
    {
        public int Id { get; set; }
        public string Marca { get; set; } = null!;
        public string Modello { get; set; } = null!;
        public string Telaio { get; set; } = null!;
        public string? Targa { get; set; } = null;
        public int Porte { get; set; }
    }
}
