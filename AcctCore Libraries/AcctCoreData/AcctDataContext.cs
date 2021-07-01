using System;
using Microsoft.EntityFrameworkCore;
using AcctCoreDomain;
using System.IO;

namespace AcctCoreData
{
	public class AcctDataContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Entry> Entries { get; set; }
		public DbSet<EntryLine> EntryLines { get; set; }
		//public DbSet<Tag> Tags { get; set; }

		private readonly StreamWriter logStream = new StreamWriter("acctcore.txt", append: true);

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string conn = @"Data Source=OV-FS2\OVSQL;Initial Catalog=AcctData;Integrated Security=True";
			optionsBuilder.UseSqlServer(conn).LogTo(logStream.WriteLine);
			//base.OnConfiguring(optionsBuilder);
		}
	}
}
