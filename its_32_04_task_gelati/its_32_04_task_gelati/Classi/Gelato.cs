﻿namespace its_32_04_task_gelati.Classi
{
    public class Gelato
    {
        public int Id { get; set; }
        public String Gusto { get; set; } = null!;

        public decimal Disponibile { get; set; } = 0;
        public decimal Prodotto { get; set; } = 0;
        public decimal Acquistato { get; set; } = 0;
        public decimal Prezzo { get; set; } = 0;

        public String Codice { get; set; } = Guid.NewGuid().ToString();
    }
}
