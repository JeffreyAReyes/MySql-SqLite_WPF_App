namespace MySql_SqLite_Synchronization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDTO : DbMigration
    {
        public override void Up()
        {
            AddColumn("Users", "Contract_Id_Value", c => c.Int());
            AddColumn("Users", "Discriminator", c => c.String(nullable: false, maxLength: 128, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("Users", "Discriminator");
            DropColumn("Users", "Contract_Id_Value");
        }
    }
}
