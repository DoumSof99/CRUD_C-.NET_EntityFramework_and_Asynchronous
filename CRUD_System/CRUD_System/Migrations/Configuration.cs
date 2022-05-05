namespace CRUD_System.Migrations
{
    using CRUD_System.models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUD_System.models.MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUD_System.models.MyDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            IList<Detail> defaultDetail = new List<Detail>();

            defaultDetail.Add(new Detail() { Name = "Sofia1", Lastname = "Doumani1", Age = 23, Address = "Secret1", Birthday = DateTime.Now });
            defaultDetail.Add(new Detail() { Name = "Sofia2", Lastname = "Doumani2", Age = 24, Address = "Secret2", Birthday = DateTime.Now });
            defaultDetail.Add(new Detail() { Name = "Sofia3", Lastname = "Doumani3", Age = 25, Address = "Secret3", Birthday = DateTime.Now });

            foreach (Detail det in defaultDetail)
            {
                context.Details.Add(det);
            }

            base.Seed(context);

        }
    }
}
