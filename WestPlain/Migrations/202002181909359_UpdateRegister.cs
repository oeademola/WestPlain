namespace WestPlain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRegister : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registers", "BusinessTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Registers", "BusinessTypeId");
            AddForeignKey("dbo.Registers", "BusinessTypeId", "dbo.BusinessTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registers", "BusinessTypeId", "dbo.BusinessTypes");
            DropIndex("dbo.Registers", new[] { "BusinessTypeId" });
            DropColumn("dbo.Registers", "BusinessTypeId");
        }
    }
}
