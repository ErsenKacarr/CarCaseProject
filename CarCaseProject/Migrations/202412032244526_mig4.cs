namespace CarCaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "TotalTime", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "TotalTime", c => c.Int(nullable: false));
        }
    }
}
