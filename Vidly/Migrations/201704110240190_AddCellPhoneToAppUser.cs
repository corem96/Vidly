namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCellPhoneToAppUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CellPhoneNumber", c => c.String(nullable: false, maxLength: 14));
        }

        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CellPhoneNumber");
        }
    }
}
