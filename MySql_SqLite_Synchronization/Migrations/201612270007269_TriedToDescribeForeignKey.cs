namespace MySql_SqLite_Synchronization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TriedToDescribeForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Users", "Contract_Id", "Contracts");
            DropIndex("Users", new[] { "Contract_Id" });
            AlterColumn("Users", "Contract_Id", c => c.Int(nullable: false));
            CreateIndex("Users", "Contract_Id");
            AddForeignKey("Users", "Contract_Id", "Contracts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Users", "Contract_Id", "Contracts");
            DropIndex("Users", new[] { "Contract_Id" });
            AlterColumn("Users", "Contract_Id", c => c.Int());
            CreateIndex("Users", "Contract_Id");
            AddForeignKey("Users", "Contract_Id", "Contracts", "Id");
        }
    }
}
