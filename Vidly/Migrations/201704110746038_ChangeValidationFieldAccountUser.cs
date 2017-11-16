namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeValidationFieldAccountUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CellPhoneNumber", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CellPhoneNumber", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
