namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedGenreReference : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre_GenreType", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "Genre_GenreType");
        }
    }
}
