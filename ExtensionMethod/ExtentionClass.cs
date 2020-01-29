namespace ExtensionMethod
{
    public static class ExtentionClass
    {
        public static double CalculateVat(this Product p)
        {
            return (p.Price * .25);
        }
    }
}
