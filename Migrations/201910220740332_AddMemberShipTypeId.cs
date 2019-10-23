namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId_Id" });
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeId_Id", newName: "MembershipTypeId");
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeId", newName: "MembershipTypeId_Id");
            CreateIndex("dbo.Customers", "MembershipTypeId_Id");
            AddForeignKey("dbo.Customers", "MembershipTypeId_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
