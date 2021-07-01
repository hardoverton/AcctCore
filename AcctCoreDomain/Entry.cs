using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcctCoreDomain
{
	public class Entry : BaseModel
	{
		#region Fields
		private int entryID;
		private bool genJournal;
		private DateTime eDate;
		private List<EntryLine> entries;
		#endregion

		#region Properties
		public int EntryID
		{
			get { return entryID; }
			set 
			{ 
				entryID = value;
				OnPropertyChanged();
			}
		}
		public bool GeneralJournal
		{
			get { return genJournal; }
			set 
			{ 
				genJournal = value;
				OnPropertyChanged();
			}
		}
		public DateTime Date
		{
			get { return eDate; }
			set 
			{ 
				eDate = value;
				OnPropertyChanged();
			}
		}
		public List<EntryLine> Lines
		{
			get { return entries; }
			set 
			{ 
				entries = value;
				OnPropertyChanged();
			}
		}

		#endregion

		#region Constructors
		public Entry()
		{
			entryID = 0;
			eDate = DateTime.MinValue;
			genJournal = false;
			//Lines = new List<EntryLine>();
		}
		public Entry(int entID, DateTime dt, bool gj=false, List<EntryLine> el = null)
		{
			entryID = entID;
			eDate = dt;
			GeneralJournal = gj;
			//Lines = new List<EntryLine>();
			//Lines = el;		// need to copy or byValue
		}
		#endregion

		#region Methods
		private int GetNextEntryID()
		{
			// Get From Database or maintain internal list
			return 0;
		}
		public bool IsBalanced()
		{
			double balance = 0.0;
			foreach (EntryLine ent in Lines)
			{
				switch (ent.Type)
				{
					case (int)EntryType.DR:
						balance += (double)ent.Deposit;
						break;
					case (int)EntryType.CR:
						balance -= (double)ent.Payment;
						break;
				}
			}
			return balance == 0.0 ? true : false;
		}
		public bool HasAccount(int acctID)
		{
			foreach (EntryLine el in Lines)
			{
				if (el.AcctNum == acctID)
					return true;
			}
			return false;
		}
		public void AddTags(string tags)
		{

		}
		public void AddTags(int tag)
		{

		}
		#endregion


	}

	public class FullEntry : BaseModel
	{

		private Entry entry;
		private ObservableCollection<EntryLine> lines;

		public Entry Entry
		{
			get { return entry; }
			set
			{
				entry = value;
				OnPropertyChanged(nameof(Entry));
			}
		}
		public ObservableCollection<EntryLine> EntryLines
		{
			get { return lines; }
			set
			{
				lines = value;
				OnPropertyChanged(nameof(EntryLines));
			}
		}

		public FullEntry()
		{ }

		public FullEntry(Entry ent = null, ObservableCollection<EntryLine> ln = null)
		{
			entry = ent;
			lines = ln;
		}
	}
}


