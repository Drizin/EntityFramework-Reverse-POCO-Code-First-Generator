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

    // Table4
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Table4Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Table4>
    {
        public Table4Configuration()
            : this("dbo")
        {
        }

        public Table4Configuration(string schema)
        {
            ToTable("Table4", schema);
            HasKey(x => x.Table4ID);

            Property(x => x.Table4ID).HasColumnName(@"Table4ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Info).HasColumnName(@"Info").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Table1).WithMany(b => b.Table4).HasForeignKey(c => c.Info).WillCascadeOnDelete(false); // FK_Table4_Table1Info
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
