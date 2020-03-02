namespace WestPlain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBusinessTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BUSINESSTYPES (Id, Name) VALUES (1, 'Corporate')");
            Sql("INSERT INTO BUSINESSTYPES (Id, Name) VALUES (2, 'Partnership')");
            Sql("INSERT INTO BUSINESSTYPES (Id, Name) VALUES (3, 'Other')");
        }

        public override void Down()
        {
        }
    }
}
