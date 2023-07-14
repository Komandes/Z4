namespace Z4
{
    public static class VAT
    {
        public static readonly HashSet<string> DostepneKategorieVAT = new HashSet<string>
    {
        "VAT-23%",
        "VAT-8%",
        "VAT-5%",
        "VAT-0%"
    };

        public static bool KategoriaVAT(string kategoriaVAT)
        {
            return DostepneKategorieVAT.Contains(kategoriaVAT);
        }
    }
}
