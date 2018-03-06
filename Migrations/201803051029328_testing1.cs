namespace mvctest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Pages", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Pages");
            DropColumn("dbo.Authors", "Age");
        }
    }
}
