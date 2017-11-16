namespace ERPTP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidtaionRequiredinMovie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "IsSubscribedToNewsletter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
