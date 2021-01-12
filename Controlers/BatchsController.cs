namespace SerialPortApp.Controlers
{
    using SerialPortApp.Datalayer;
    using SerialPortApp.Models;
    using System.Collections.Generic;
    using System.Linq;
    public class BatchsController
    {
        AppDbContextSqlServer AppdbContext;
        public BatchsController() 
        {
            Conectar();
        }

        public void Conectar()
        {
            AppdbContext = new AppDbContextSqlServer();
        }
        public void Add(Batchs batch)
        {
            AppdbContext.Batchs.Add(batch);
            AppdbContext.SaveChanges();
        }
        public void Update(Batchs batch)
        {
            var item = AppdbContext.Batchs.Find(batch.Id);
            if(item != null)
            {
                batch.BatchNumber = batch.BatchNumber;
                batch.DateOpen = batch.DateOpen;
                batch.Description = batch.Description;
                batch.Person = batch.Person;
            };
            AppdbContext.SaveChanges();
        }
        public void Detele(int id)
        {
            var  item = AppdbContext.Batchs.Find(id);
            if (item != null)
            {
                AppdbContext.Batchs.Remove(item);
                AppdbContext.SaveChanges();
            }
        }
        public List<Batchs> List()
        {
            List<Batchs> mylist = AppdbContext.Batchs.ToList();
            return mylist;
        }
        public Batchs GetElementById()
        {
            Batchs item = new Batchs();
            return item;
        }
    }
}
