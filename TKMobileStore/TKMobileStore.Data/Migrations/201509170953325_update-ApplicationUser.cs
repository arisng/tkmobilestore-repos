namespace TKMobileStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "UpdatedOn");
            DropColumn("dbo.AspNetUsers", "CreatedOn");
        }
    }
}
