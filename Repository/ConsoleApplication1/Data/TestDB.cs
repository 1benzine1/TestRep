namespace ConsoleApplication1.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TestDB : DbContext
    {
        // Контекст настроен для использования строки подключения "TestDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ConsoleApplication1.Data.TestDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "TestDB" 
        // в файле конфигурации приложения.

        public TestDB()
            : base("name=TestDB")
        {
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<YardRacers> YardRacers { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}