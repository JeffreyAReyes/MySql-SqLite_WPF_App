namespace MySql_SqLite_Synchronization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDTOs : DbMigration
    {
        public override void Up()
        {
            DropColumn("Users", "Contract_Id_Value");
            DropColumn("Users", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("Users", "Discriminator", c => c.String(nullable: false, maxLength: 128, storeType: "nvarchar"));
            AddColumn("Users", "Contract_Id_Value", c => c.Int());
        }
    }
}
