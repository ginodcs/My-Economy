namespace MyEconomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNamePropertiesToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirsName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirsName");
        }
    }
}
