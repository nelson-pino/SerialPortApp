namespace SerialPortApp.Controlers
{
    using SerialPortApp.Datalayer;
    using SerialPortApp.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductsController
    {
        AppDbContextSqlServer AppdbContext;

        public ProductsController() 
        {
            Conectar();
        }
        public void Conectar()
        {
            AppdbContext = new AppDbContextSqlServer();
        }
        public void Add(Products producto) 
        {
            AppdbContext.Products.Add(producto);
            AppdbContext.SaveChanges();
        }
        public void Update(Products producto) 
        {
            AppdbContext.Entry(producto);
            AppdbContext.SaveChanges();
        }
        public void Detele(string id) 
        {
            var producto = AppdbContext.Products.Find(id);
            AppdbContext.Products.Remove(producto);
        }
        public List<Products> List() 
        {
            List<Products> mylist = new List<Products>();
            mylist = AppdbContext.Products.ToList();
            return mylist;
        }
        public Products GetElementById(int id) 
        {
            Products myproduct = new Products();
            return myproduct;
        }
    }
}
