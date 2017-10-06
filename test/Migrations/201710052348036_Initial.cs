namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
            "dbo.Blog",
            c => new
                {
                    ID = c.Int(nullable: false),
                    Title = c.String(),
                    Content = c.String(nullable: false),
                })
            .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
        }
    }
}
