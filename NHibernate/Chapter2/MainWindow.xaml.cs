using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate;


namespace Chapter2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string connStrng = "Data Source=localhost;Initial Catalog=NH3BeginnersGuide;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateDatabase_Click(object sender, RoutedEventArgs e)
        {
            
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(connStrng))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>())
                .ExposeConfiguration(CreateSchema)
                .BuildConfiguration();
        }

        private static void CreateSchema(Configuration cfg) 
        {
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Drop(false, true);
            schemaExport.Create(false, true);
        }

        private ISessionFactory CreateSessionFactory() 
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(connStrng))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>())
                .BuildSessionFactory();
        }

        private void btnCreateSessionFactory_Click(object sender, RoutedEventArgs e)
        {
            var factory = CreateSessionFactory();
        }

        private void btnCreateSession_Click(object sender, RoutedEventArgs e)
        {
            var factory = CreateSessionFactory();

            using (var session = factory.OpenSession())
            {
                var category = new Category
                {
                    Name = "Beverages",
                    Description = "Some Description"
                };
                var product = new Product {
                    Name= "Milk",
                    Category = category
                };
                session.Save(category);
                session.Save(product);
            }
        }
    }
}
