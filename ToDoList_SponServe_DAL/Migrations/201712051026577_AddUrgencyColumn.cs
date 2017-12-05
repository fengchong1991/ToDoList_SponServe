namespace ToDoList_SponServe_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrgencyColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Urgency", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "Urgency");
        }
    }
}
