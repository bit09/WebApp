namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Name) values('Action')");
            Sql("insert into Genres(Name) values('Thriller')");
            Sql("insert into Genres(Name) values('Family')");
            Sql("insert into Genres(Name) values('Romance')");
            Sql("insert into Genres(Name) values('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
