namespace BackEndProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modiftDateinPackageColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Packages", "StartDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Packages", "EndDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Packages", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Packages", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
