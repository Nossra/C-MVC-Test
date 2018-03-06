namespace mvctest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Authors_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Authors_Id" });
            AlterColumn("dbo.Books", "Authors_Id", c => c.Int());
            CreateIndex("dbo.Books", "Authors_Id");
            AddForeignKey("dbo.Books", "Authors_Id", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Authors_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Authors_Id" });
            AlterColumn("dbo.Books", "Authors_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "Authors_Id");
            AddForeignKey("dbo.Books", "Authors_Id", "dbo.Authors", "Id", cascadeDelete: true);
        }
    }
}
