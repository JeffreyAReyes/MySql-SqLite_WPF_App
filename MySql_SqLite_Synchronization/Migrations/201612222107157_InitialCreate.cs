namespace MySql_SqLite_Synchronization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Contracts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Login = c.String(),
                    Password = c.String(),
                    Admin = c.Boolean(nullable: false),
                    Contract_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Contracts", t => t.Contract_Id)
                .Index(t => t.Contract_Id);

        }
        
        public override void Down()
        {
            DropForeignKey("Users", "Contract_Id", "Contracts");
            DropIndex("Users", new[] { "Contract_Id" });
            DropTable("Users");
            DropTable("Contracts");
        }
    }
}
