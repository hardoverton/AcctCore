using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcctCoreDomain
{
	public class Account : BaseModel
	{
		#region Fields
		private int acctID;
		private string acctName;
		private int acctNumber;
		private int acctType;
		private double openBalance;
		private double acctBalance;
		private string acctDescription;
		private int isSubOf;
		private int inGroup;
		private ObservableCollection<EntryLine> entryLines;
		#endregion

		#region Properties
		//public int ID
		//{
		//	get { return acctID; }
		//	set { acctID = value; }
		//}
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int AccountNumber
		{
			get { return acctNumber; }
			set
			{
				acctNumber = value;
				OnPropertyChanged();
			}
		}
		public string AccountName
		{
			get { return acctName; }
			set
			{
				acctName = value;
				OnPropertyChanged();
			}
		}
		public int AccountType
		{
			get { return acctType; }
			set
			{
				acctType = value;
				OnPropertyChanged();
			}
		}
		public ObservableCollection<EntryLine> EntryLines
		{
			get { return entryLines; }
			set 
			{
				entryLines = value;
				OnPropertyChanged();
			}
		}
		public double OpeningBalance
		{
			get { return openBalance; }
			set
			{
				openBalance = value;
				OnPropertyChanged();
			}
		}
		public double Balance
		{
			get { return acctBalance; }
			set
			{
				acctBalance = value;
				OnPropertyChanged();
			}
		}
		public string Description
		{
			get { return acctDescription; }
			set
			{
				acctDescription = value;
				OnPropertyChanged();
			}
		}
		public int IsSubOf
		{
			get { return isSubOf; }
			set
			{
				isSubOf = value;
				OnPropertyChanged();
			}
		}
		public int InGroup
		{
			get { return inGroup; }
			set
			{
				inGroup = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Constructors
		public Account()
		{
			//acctID = 0;
			acctName = "";
			acctNumber = 0;
			acctType = 0;
			acctBalance = 0.0;
			acctDescription = "";
			isSubOf = 0;
		}
		public Account(int num, string nam, int typ)
		{
			//acctID = 0;
			acctName = nam;
			acctNumber = num;
			acctType = typ;
			//acctBalance = bal;
			//acctDescription = desc;
			//isSubOf = sub;
		}
		#endregion

		#region Methods
		public int GetNewID()
		{
			return 0;
		}
		#endregion


	}

	public class BaseAcct : BaseModel
	{
		private int acctNumber;
		private string acctName;

		public int Acct
		{
			get { return acctNumber; }
			set { acctNumber = value; }
		}
		public string Name
		{
			get { return acctName; }
			set { acctName = value; }
		}

		public BaseAcct(int acct, string nam)
		{
			acctNumber = acct;
			acctName = nam;
		}
	}
}
