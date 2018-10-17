namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (6,'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Biography')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Documentary')");
        }
        
        public override void Down()
        {
        }
    }
}
