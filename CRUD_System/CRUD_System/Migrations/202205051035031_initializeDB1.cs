namespace CRUD_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initializeDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lastname = c.String(),
                        Age = c.Int(nullable: false),
                        Address = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Details");
        }
    }
}
