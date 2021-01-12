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
            var item = AppdbContext.Products.Find(producto.ProductID);
            if (item != null)
            {
                item.ProductName = producto.ProductName;
                item.ProductCategory = producto.ProductCategory;
                item.Departament = producto.Departament;
                item.Tax = producto.Tax;
                item.Ingredients = producto.Ingredients;
                item.CodePersonolize = producto.CodePersonolize;
                item.UnitPrice = producto.UnitPrice;
                item.UnitShop = producto.UnitShop;
            }
            AppdbContext.SaveChanges();
        }
        public void Detele(int id) 
        {
            var producto = AppdbContext.Products.Find(id);
            if (producto != null) 
            {
                AppdbContext.Products.Remove(producto);
                AppdbContext.SaveChanges();
            }
        }
        public List<Products> List() 
        {
            List<Products> mylist = AppdbContext.Products.ToList();
            return mylist;
        }
        public Products GetElementById() 
        {
            Products myproduct = new Products();
            return myproduct;
        }
    }
}
