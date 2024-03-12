namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Chefs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Chefs",
                c => new
                    {
                        ChefId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        NameSurname = c.String(),
                    })
                .PrimaryKey(t => t.ChefId);
            
        }
    }
}
