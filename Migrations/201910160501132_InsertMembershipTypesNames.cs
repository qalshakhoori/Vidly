namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMembershipTypesNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name='Pay As You Go' where ID=1");
            Sql("UPDATE MembershipTypes set Name='Monthly' where ID=2");
            
        }
        
        public override void Down()
        {
        }
    }
}
