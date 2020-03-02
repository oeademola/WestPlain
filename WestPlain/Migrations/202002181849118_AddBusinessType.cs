namespace WestPlain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBusinessType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusinessTypes");
        }
    }
}
