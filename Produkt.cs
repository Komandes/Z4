namespace Z4
{
    public abstract class Produkt
    {
        public string Nazwa { get; set; }
        decimal cenaNetto;
        public decimal CenaNetto
        {
            get { return cenaNetto; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena netto nie może być ujemna.");
                cenaNetto = value;
            }
        }
        private string kategoriaVAT;
        public string KategoriaVAT
        {
            get { return kategoriaVAT; }
            set
            {
                if (!VAT.KategoriaVAT(value))
                    throw new ArgumentException("Nieprawidłowa kategoria VAT.");
                kategoriaVAT = value;
            }
        }
        public decimal CenaBrutto
        {
            get { return CenaNetto * (1 + StawkaVAT(KategoriaVAT)); }
        }
        public virtual decimal StawkaVAT(string kategoriaVAT)
        {
            switch (kategoriaVAT)
            {
                case "VAT-23%":
                    return 0.23m;
                case "VAT-8%":
                    return 0.08m;
                case "VAT-5%":
                    return 0.05m;
                case "VAT-0%":
                    return 0m;
                default:
                    throw new ArgumentException("Nieprawidłowa kategoria VAT.");
            }
        }

        public string KrajPochodzenia { get; set; }
    }

}
