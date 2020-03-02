namespace WestPlain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewsletter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Newsletters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Newsemail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Newsletters");
        }
    }
}
