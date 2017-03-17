namespace Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Birthdate");
        }
    }
}
