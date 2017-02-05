// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ConsoleApplication1.Entities
{

    // Table1
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Table1Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Table1>
    {
        public Table1Configuration()
            : this("dbo")
        {
        }

        public Table1Configuration(string schema)
        {
            ToTable("Table1", schema);
            HasKey(x => x.Table1ID);

            Property(x => x.Table1ID).HasColumnName(@"Table1ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Info).HasColumnName(@"Info").HasColumnType("int").IsOptional();
            HasMany(t => t.Table3).WithMany(t => t.Table1).Map(m =>
            {
                m.ToTable("Table1To3", "dbo");
                m.MapLeftKey("Table1ID");
                m.MapRightKey("Table3ID");
            });
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
