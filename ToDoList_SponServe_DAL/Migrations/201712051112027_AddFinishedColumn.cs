namespace ToDoList_SponServe_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFinishedColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Finished", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "Finished");
        }
    }
}
