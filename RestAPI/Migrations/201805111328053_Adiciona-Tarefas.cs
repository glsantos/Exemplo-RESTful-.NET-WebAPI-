namespace RestAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionaTarefas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tarefas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        titulo = c.String(maxLength: 50),
                        Descricao = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tarefas");
        }
    }
}
