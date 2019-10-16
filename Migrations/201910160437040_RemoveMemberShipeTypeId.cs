namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMemberShipeTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId_Id" });
            DropColumn("dbo.Customers", "MembershipTypeId_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypeId_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MembershipTypeId_Id");
            AddForeignKey("dbo.Customers", "MembershipTypeId_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
