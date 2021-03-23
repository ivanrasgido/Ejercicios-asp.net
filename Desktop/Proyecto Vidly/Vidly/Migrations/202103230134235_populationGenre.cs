namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populationGenre : DbMigration
    {
        public override void Up()
        {


            Sql("SET IDENTITY_INSERT Genres ON");



        }
        
        public override void Down()
        {
        }
    }
}
