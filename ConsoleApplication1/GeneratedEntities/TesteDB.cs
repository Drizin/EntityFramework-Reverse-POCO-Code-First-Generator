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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class TesteDB : System.Data.Entity.DbContext, ITesteDB
    {
        public System.Data.Entity.DbSet<Table1> Table1 { get; set; } // Table1
        public System.Data.Entity.DbSet<Table1To6> Table1To6 { get; set; } // Table1To6
        public System.Data.Entity.DbSet<Table2> Table2 { get; set; } // Table2
        public System.Data.Entity.DbSet<Table3> Table3 { get; set; } // Table3
        public System.Data.Entity.DbSet<Table4> Table4 { get; set; } // Table4
        public System.Data.Entity.DbSet<Table5> Table5 { get; set; } // Table5
        public System.Data.Entity.DbSet<Table6> Table6 { get; set; } // Table6
        public System.Data.Entity.DbSet<Table7> Table7 { get; set; } // Table7
        public System.Data.Entity.DbSet<Table8> Table8 { get; set; } // Table8
        public System.Data.Entity.DbSet<Table9> Table9 { get; set; } // Table9

        static TesteDB()
        {
            System.Data.Entity.Database.SetInitializer<TesteDB>(null);
            TesteDBStaticPartial(); // Create the following method in your partial class: private static void TesteDBStaticPartial() { }
        }

        public TesteDB()
            : base("Name=DefaultConnection")
        {
            InitializePartial();
        }

        public TesteDB(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public TesteDB(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public TesteDB(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public TesteDB(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Table1Configuration());
            modelBuilder.Configurations.Add(new Table1To6Configuration());
            modelBuilder.Configurations.Add(new Table2Configuration());
            modelBuilder.Configurations.Add(new Table3Configuration());
            modelBuilder.Configurations.Add(new Table4Configuration());
            modelBuilder.Configurations.Add(new Table5Configuration());
            modelBuilder.Configurations.Add(new Table6Configuration());
            modelBuilder.Configurations.Add(new Table7Configuration());
            modelBuilder.Configurations.Add(new Table8Configuration());
            modelBuilder.Configurations.Add(new Table9Configuration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new Table1Configuration(schema));
            modelBuilder.Configurations.Add(new Table1To6Configuration(schema));
            modelBuilder.Configurations.Add(new Table2Configuration(schema));
            modelBuilder.Configurations.Add(new Table3Configuration(schema));
            modelBuilder.Configurations.Add(new Table4Configuration(schema));
            modelBuilder.Configurations.Add(new Table5Configuration(schema));
            modelBuilder.Configurations.Add(new Table6Configuration(schema));
            modelBuilder.Configurations.Add(new Table7Configuration(schema));
            modelBuilder.Configurations.Add(new Table8Configuration(schema));
            modelBuilder.Configurations.Add(new Table9Configuration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}
// </auto-generated>
