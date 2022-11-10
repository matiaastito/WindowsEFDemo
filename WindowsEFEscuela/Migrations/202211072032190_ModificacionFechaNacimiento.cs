namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionFechaNacimiento : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alumno", "FechaNacimiento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alumno", "FechaNacimiento", c => c.DateTime(nullable: false));
        }
    }
}
