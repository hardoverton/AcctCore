using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcctCoreDomain
{
	public class EntryLine : BaseModel
	{
		#region Fields
		private int entryID;
		private int lineID;
		private int acctNumber;
		private int oppAccount;
		private DateTime date;
		private int eType;
		private string ePayee;
		private double ePmt;
		private double eDep;
		private string eMemo;
		private int? eClass;
		//private ObservableCollection<Tag> eTags;
		private int? eCategory;
		private string eCleared;
		private string eChkNum;
		private double balance;
		//private ObservableCollection<EntryLine> lineDetail;
		#endregion


		#region Properties
		[Key]
		public int LineID
		{
			get { return lineID; }
			set { lineID = value; }
		}
		public int EntryID
		{
			get { return entryID; }
			set { entryID = value; }
		}
		[ForeignKey("Account")]
		public int AcctNum
		{
			get { return acctNumber; }
			set
			{
				acctNumber = value;
				OnPropertyChanged();
			}
		}
		public int OppAccountNum
		{
			get { return oppAccount; }
			set
			{
				oppAccount = value;
				OnPropertyChanged();
			}
		}
		public int Type       //  EntryType.DR or EntryType.CR
		{
			get { return eType; }
			set 
			{ 
				eType = value; 
			}
		}
		public DateTime Date
		{
			get { return date; }
			set
			{
				date = value;
				OnPropertyChanged();
			}
		}
		public string Payee
		{
			get { return ePayee; }
			set 
			{ 
				ePayee = value;
				OnPropertyChanged();
			}
		}
		public double Deposit
		{
			get { return eDep; }
			set
			{
				eDep = (double)value;
				OnPropertyChanged();
			}
		}
		public double Payment
		{
			get { return ePmt; }
			set
			{
				ePmt = (double)value;
				OnPropertyChanged();
			}
		}
		public string Memo
		{
			get { return eMemo; }
			set 
			{ 
				eMemo = value;
				OnPropertyChanged();
			}
		}
		public int? Class
		{
			get { return eClass; }
			set
			{
				eClass = (int?)value;
				OnPropertyChanged();
			}
		}
		//public ObservableCollection<Tag> Tags
		//{
		//	get { return eTags; }
		//	set
		//	{
		//		eTags = value;
		//		OnPropertyChanged();
		//	}
		//}
		public int? Category
		{
			get { return eCategory; }
			set 
			{ 
				eCategory = (int?)value;
				OnPropertyChanged();
			}
		}
		public string Cleared
		{
			get { return eCleared; }
			set
			{
				if (value == "R" || value == "C" || value == "")
				{
					eCleared = value;
					OnPropertyChanged();
				}
				else
				{
					// validation error
				}
			}
		}
		public string ChkNum
		{
			get { return eChkNum; }
			set
			{
				eChkNum = value;
				OnPropertyChanged();
			}
		}
		public double Balance
		{
			get { return balance; }
			set 
			{ 
				balance = (double)value;
				OnPropertyChanged();
			}
		}
		//public ObservableCollection<EntryLine> LineDetail
		//{
		//	get { return lineDetail; }
		//	set
		//	{
		//		lineDetail = value;
		//		OnPropertyChanged();
		//	}
		//}

		#endregion

		#region Constructors
		public EntryLine()
		{ }
		public EntryLine(int eID, int linID, int aNmbr, DateTime dt, int eTyp, string payee, double dep, double pmt,
			string mem, int cls, 
			//ObservableCollection<Tag> tg = null, 
			int cat = 0, string clrd = "", string chk = "")
		{
			EntryID = eID;
			LineID = linID;
			AcctNum = aNmbr;
			Type = eTyp;
			Payee = payee;
			Deposit = dep;
			Payment = pmt;
			Memo = mem;
			Class = cls;
			//Tags = tg;
			Category = cat;
			Cleared = clrd;
			ChkNum = chk;
			Balance = 0;
		}
		#endregion

		#region Methods
		#endregion

	}
}

