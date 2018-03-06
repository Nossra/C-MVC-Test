namespace mvctest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Authors_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Authors_Id)
                .Index(t => t.Authors_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Authors_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Authors_Id" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
