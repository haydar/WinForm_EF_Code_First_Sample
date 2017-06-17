namespace WinForm_EF_Code_First_Sample
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ListPrice { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category  { get; set; }
    }
}