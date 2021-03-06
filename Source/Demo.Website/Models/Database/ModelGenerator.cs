// This file was automatically generated by the Dapper.SimpleCRUD T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `DemoConnectionString`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `MultipleActiveResultSets=True;Data Source=.\sqlexpress;Initial Catalog=Demo;Integrated Security=True`
//     Include Views:          `True`

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Website.Models.Database
{
    /// <summary>
    /// A class which represents the TestTable table.
    /// </summary>
	[Table("TestTable")]
	public partial class TestTable : BaseModel
	{
		[Key]
		public virtual int Id { get; set; }
		public virtual string FullName { get; set; }
		public virtual int value1 { get; set; }
		public virtual int value2 { get; set; }
	}

    /// <summary>
    /// A class which represents the usd_AppliedDatabaseSeedScript table.
    /// </summary>
	[Table("usd_AppliedDatabaseSeedScript")]
	public partial class usdAppliedDatabaseSeedScript : BaseModel
	{
		public virtual string ScriptFile { get; set; }
		public virtual DateTime DateApplied { get; set; }
	}

}
