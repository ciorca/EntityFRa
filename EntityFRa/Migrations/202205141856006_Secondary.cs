namespace EntityFRa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secondary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Gender");
        }
    }
}
