namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMembershipTypesNames1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name='Quarterly' where ID=3");
            Sql("UPDATE MembershipTypes set Name='Yearly' where ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
