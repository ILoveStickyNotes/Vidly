namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Genre) VALUES ('Comedy')");
            Sql("INSERT INTO GenreTypes (Genre) VALUES ('Action')");
            Sql("INSERT INTO GenreTypes (Genre) VALUES ('Family')");
            Sql("INSERT INTO GenreTypes (Genre) VALUES ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
