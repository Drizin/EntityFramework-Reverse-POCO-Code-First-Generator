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

    // Table2
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Table2Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Table2>
    {
        public Table2Configuration()
            : this("dbo")
        {
        }

        public Table2Configuration(string schema)
        {
            ToTable("Table2", schema);
            HasKey(x => x.Table2ID);

            Property(x => x.Table2ID).HasColumnName(@"Table2ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Table1ID).HasColumnName(@"Table1ID").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Table1).WithMany(b => b.Table2).HasForeignKey(c => c.Table1ID).WillCascadeOnDelete(false); // FK_Table2_Table1ID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
