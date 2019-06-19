namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameStrLengthSetToActor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Actor", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Actor", "Name", c => c.String());
        }
    }
}
