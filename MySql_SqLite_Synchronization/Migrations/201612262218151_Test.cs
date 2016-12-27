namespace MySql_SqLite_Synchronization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Contracts", "Title", c => c.String(unicode: false));
            AlterColumn("Users", "Name", c => c.String(unicode: false));
            AlterColumn("Users", "Login", c => c.String(unicode: false));
            AlterColumn("Users", "Password", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("Users", "Password", c => c.String());
            AlterColumn("Users", "Login", c => c.String());
            AlterColumn("Users", "Name", c => c.String());
            AlterColumn("Contracts", "Title", c => c.String());
        }
    }
}
