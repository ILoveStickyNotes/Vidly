namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VariousChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenreTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "GenreType_Id", c => c.Int());
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
            DropColumn("dbo.Movies", "Genre_GenreType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre_GenreType", c => c.String());
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            DropColumn("dbo.Movies", "GenreType_Id");
            DropColumn("dbo.Movies", "GenreTypeId");
            DropTable("dbo.GenreTypes");
        }
    }
}
