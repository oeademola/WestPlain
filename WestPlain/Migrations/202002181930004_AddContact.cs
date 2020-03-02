namespace WestPlain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                  "dbo.Contacts",
                  c => new
                  {
                      Id = c.Int(nullable: false, identity: true),
                      Name = c.String(nullable: false, maxLength: 255),
                      Email = c.String(),
                      PhoneNumber = c.String(),
                      Message = c.String(),
                  })
                  .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
        }
    }
}
