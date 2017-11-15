namespace ERPTP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsSubscribe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "IsSubscribedToNewsletter");
        }
    }
}
