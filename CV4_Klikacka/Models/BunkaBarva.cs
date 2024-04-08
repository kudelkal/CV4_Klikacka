namespace CV4_Klikacka.Models
{
    public class BunkaBarva : Bunka
    {
        public BunkaBarva(int sloupec) : base(radka: 0, sloupec, hod: sloupec)
        {
            StyleIndexBarvy = sloupec;
        }

        public bool Selected { get; set; } = false;
        public string StyleClassNameSelected => Selected ? "selected" : "";
        //public override string StyleClassName => $"barva-{StyleIndexBarvy} {StyleClassNameSelected}";
        public override string StyleClassName => $"{base.StyleClassName} {StyleClassNameSelected}";
    }
}
