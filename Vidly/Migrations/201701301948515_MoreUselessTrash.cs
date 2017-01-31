namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreUselessTrash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String());
            DropColumn("dbo.Customers", "BirthDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BirthDay", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
