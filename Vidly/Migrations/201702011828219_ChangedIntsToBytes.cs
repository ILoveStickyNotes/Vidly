namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedIntsToBytes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            DropColumn("dbo.Movies", "GenreTypeId");
            RenameColumn(table: "dbo.Movies", name: "GenreType_Id", newName: "GenreTypeId");
            DropPrimaryKey("dbo.Movies");
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.GenreTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            DropPrimaryKey("dbo.GenreTypes");
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.GenreTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Int());
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.GenreTypes", "Id");
            AddPrimaryKey("dbo.Movies", "Id");
            RenameColumn(table: "dbo.Movies", name: "GenreTypeId", newName: "GenreType_Id");
            AddColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
    }
}
