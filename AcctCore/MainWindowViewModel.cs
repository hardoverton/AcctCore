using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcctCoreDomain;
using AcctCoreData;
using Microsoft.EntityFrameworkCore;

namespace AcctCore
{
	public class MainWindowViewModel:BaseModel
	{
		private static AcctDataContext dataContext = new AcctDataContext();

		#region Fields
		private ObservableCollection<Account> accountSet = new ObservableCollection<Account>();
		private ObservableCollection<Entry> entrySet = new ObservableCollection<Entry>();
		private ObservableCollection<EntryLine> entryLineSet = new ObservableCollection<EntryLine>();
		#endregion

		#region Properties
		public ObservableCollection<Account> AccountSet
		{
			get { return accountSet; }
			set 
			{ 
				accountSet = value;
				OnPropertyChanged();
			}
		}
		public ObservableCollection<Entry> EntrySet
		{
			get { return entrySet; }
			set
			{
				entrySet = value;
				OnPropertyChanged();
			}
		}
		public ObservableCollection<EntryLine> EntryLineSet
		{
			get { return entryLineSet; }
			set
			{
				entryLineSet = value;
				OnPropertyChanged();
			}
		}
		#endregion

		public MainWindowViewModel()
		{		}

		public void BuildAccounts()
		{
			dataContext.Database.EnsureCreated();

			AddAccount(1110, "Frost Checking", 1);
			AddAccount(1120, "Frost Savings", 1);
			AddAccount(1150, "OV Checking", 1);
			#region additional adds
			//AddAccount(1160, "RHPiano Checking", 1);
			//AddAccount(1170, "Harmony Checking", 1);
			//AddAccount(1180, "PayPal", 1);
			//AddAccount(1210, "Cash Account", 1);
			//AddAccount(1220, "Amazon Gift Card", 1);
			//AddAccount(1230, "OV Reimburse", 1);
			//AddAccount(1240, "Britt to Reimburse", 1);
			//AddAccount(1250, "Piano Studio Reimburse", 1);
			//AddAccount(1260, "Reimburse Due Family", 1);
			//AddAccount(1270, "Harmony Reimburse", 1);
			//AddAccount(1280, "WestWind Reimburse", 1);
			//AddAccount(1310, "E*Trade Savings", 1);
			//AddAccount(1320, "E*Trade Trading", 1);
			//AddAccount(1330, "TDA IRA - John", 1);
			//AddAccount(1340, "TDA IRA - Rebecca", 1);
			//AddAccount(1350, "TDA Trading", 1);
			//AddAccount(1410, "Computers ", 1);
			//AddAccount(1420, "GMC Envoy", 1);
			//AddAccount(1430, "GMC Yukon", 1);
			//AddAccount(1440, "TVs", 1);
			//AddAccount(1450, "Bechstein Piano", 1);
			//AddAccount(1460, "House - 8608 Trace Ridge", 1);
			//AddAccount(1470, "Coin Collection", 1);
			//AddAccount(1470, "Major Assets", 1);
			//AddAccount(1480, "Jewelry", 1);
			//AddAccount(1360, "Ala. Retirement", 1);
			//AddAccount(2510, "Amazon Visa", 2);
			//AddAccount(2520, "American Express", 2);
			//AddAccount(2530, "CapitalOne Visa", 2);
			//AddAccount(2540, "Care Credit", 2);
			//AddAccount(2550, "Amazon Store Card", 2);
			//AddAccount(2650, "Bankruptcy Payout", 2);
			//AddAccount(3010, "Net Worth", 3);
			//AddAccount(4010, "St. Stephens", 4);
			//AddAccount(4011, "WestWind Church", 4);
			//AddAccount(4020, "Social Security-John", 4);
			//AddAccount(4030, "Social Security-Rebecca", 4);
			//AddAccount(4040, "John PayCheck", 4);
			//AddAccount(4041, "Brown-Mackie", 4);
			//AddAccount(4050, "Reimburse Due", 4);
			//AddAccount(4060, "Interest Income", 4);
			//AddAccount(4070, "Piano Studio", 4);
			//AddAccount(4910, "Fed Tax Withheld", 4);
			//AddAccount(4920, "State Tax Withheld", 4);
			//AddAccount(4930, "Medicare Tax Withheld", 4);
			//AddAccount(4940, "FICA Tax Withheld", 4);
			//AddAccount(4950, "Savings Plan Contribution", 4);
			//AddAccount(4960, "Health Insurance Plan Contribution", 4);
			//AddAccount(4970, "Life Insurance Plan Contribution", 4);
			//AddAccount(5010, "Banking", 5);
			//AddAccount(5011, "Banking Fees", 5);
			//AddAccount(5020, "Communication", 5);
			//AddAccount(5021, "Phones", 5);
			//AddAccount(5030, "Clothing", 5);
			//AddAccount(5031, "Clothing John", 5);
			//AddAccount(5032, "Clothing Rebecca", 5);
			//AddAccount(5033, "Dry Cleaning", 5);
			//AddAccount(5040, "Dining", 5);
			//AddAccount(5041, "Restaurants", 5);
			//AddAccount(5050, "Entertainment", 5);
			//AddAccount(5051, "Internet", 5);
			//AddAccount(5052, "Cable", 5);
			//AddAccount(5053, "Alcohol", 5);
			//AddAccount(5054, "Movies", 5);
			//AddAccount(5055, "Sports", 5);
			//AddAccount(5056, "Concerts", 5);
			//AddAccount(5057, "Streaming", 5);
			//AddAccount(5058, "Equipment", 5);
			//AddAccount(5059, "Books", 5);
			//AddAccount(5060, "Giving", 5);
			//AddAccount(5061, "Church", 5);
			//AddAccount(5062, "Birthdays & Anniveraries", 5);
			//AddAccount(5063, "Other", 5);
			//AddAccount(5070, "Food", 5);
			//AddAccount(5071, "Groceries", 5);
			//AddAccount(5075, "TakeOut", 5);
			//AddAccount(5079, "Food Miscellaneous", 5);
			//AddAccount(5080, "Housing", 5);
			//AddAccount(5081, "Property Tax", 5);
			//AddAccount(5082, "Homeowners Insurance", 5);
			//AddAccount(5083, "HOA Dues", 5);
			//AddAccount(5084, "House Cleaning", 5);
			//AddAccount(5085, "Storage", 5);
			//AddAccount(5090, "House Improvement", 5);
			//AddAccount(5091, "Rennovations", 5);
			//AddAccount(5092, "Additions", 5);
			//AddAccount(5095, "Yard Improvement", 5);
			//AddAccount(5098, "Linens, etc.", 5);
			//AddAccount(5099, "Minor Improvements", 5);
			//AddAccount(5100, "House Maintenance", 5);
			//AddAccount(5101, "House Repairs", 5);
			//AddAccount(5102, "Lawn Service", 5);
			//AddAccount(5103, "Yard", 5);
			//AddAccount(5107, "Equipment Repair", 5);
			//AddAccount(5110, "Household", 5);
			//AddAccount(5111, "Toiletries", 5);
			//AddAccount(5112, "Laundry detergent", 5);
			//AddAccount(5113, "Dishwasher detergent", 5);
			//AddAccount(5114, "Cleaning supplies", 5);
			//AddAccount(5115, "Tools", 5);
			//AddAccount(5116, "Furniture", 5);
			//AddAccount(5119, "Household Miscellaneous", 5);
			//AddAccount(5120, "Insurance", 5);
			//AddAccount(5121, "Life Insurance", 5);
			//AddAccount(5122, "Health Insurance", 5);
			//AddAccount(5123, "Service Charges", 5);
			//AddAccount(5130, "Medical", 5);
			//AddAccount(5131, "Primary Care", 5);
			//AddAccount(5132, "Dental Care", 5);
			//AddAccount(5133, "Specialists", 5);
			//AddAccount(5134, "Urgent care", 5);
			//AddAccount(5135, "Hospital", 5);
			//AddAccount(5136, "Medical Devices", 5);
			//AddAccount(5137, "Prescriptions", 5);
			//AddAccount(5138, "Supplements", 5);
			//AddAccount(5139, "Physical Therapy", 5);
			//AddAccount(5140, "Miscellaneous", 5);
			//AddAccount(5141, "Shopping Memberships", 5);
			//AddAccount(5144, "Postage", 5);
			//AddAccount(5145, "Office Supplies", 5);
			//AddAccount(5149, "Misc-Other", 5);
			//AddAccount(5150, "Personal", 5);
			//AddAccount(5151, "Gym memberships", 5);
			//AddAccount(5152, "Haircuts", 5);
			//AddAccount(5153, "Salon services", 5);
			//AddAccount(5154, "Cosmetics ", 5);
			//AddAccount(5155, "Babysitter", 5);
			//AddAccount(5156, "Subscriptions", 5);
			//AddAccount(5157, "Personal Misc", 5);
			//AddAccount(5160, "Pets", 5);
			//AddAccount(5161, "Pets Food", 5);
			//AddAccount(5162, "Pets Medical", 5);
			//AddAccount(5163, "Pets Misc", 5);
			//AddAccount(5170, "Professional Development", 5);
			//AddAccount(5171, "Associations", 5);
			//AddAccount(5172, "Subscriptions", 5);
			//AddAccount(5173, "Technical Books", 5);
			//AddAccount(5175, "Online Courses ", 5);
			//AddAccount(5180, "Taxes", 5);
			//AddAccount(5181, "Sales Tax", 5);
			//AddAccount(5182, "Income Tax", 5);
			//AddAccount(5190, "Transportation", 5);
			//AddAccount(5191, "Auto Fuel", 5);
			//AddAccount(5192, "Auto Repairs", 5);
			//AddAccount(5193, "Automobile Insurance", 5);
			//AddAccount(5194, "Registration & Fees", 5);
			//AddAccount(5195, "Wash", 5);
			//AddAccount(5196, "Parts", 5);
			//AddAccount(5200, "Travel", 5);
			//AddAccount(5210, "Utilities", 5);
			//AddAccount(5211, "Electric", 5);
			//AddAccount(5212, "Gas", 5);
			//AddAccount(5213, "Water", 5);
			//AddAccount(5214, "Garbage", 5);
			//AddAccount(5215, "Stormwater", 5);
			//AddAccount(5216, "Wastewater", 5);
			//AddAccount(5219, "Fees", 5);
			//AddAccount(5220, "Computing ", 5);
			//AddAccount(5221, "Hardware", 5);
			//AddAccount(5222, "Software", 5);
			//AddAccount(5223, "Computing Misc", 5);
			//AddAccount(5224, "Computer Parts", 5);
			//AddAccount(5230, "Hobbies/Interests", 5);
			//AddAccount(5231, "Interests John", 5);
			//AddAccount(5232, "Interests Rebecca", 5);
			#endregion
		}

		private static void AddAccount(int num, string name,  int typ)
		{
			var account = new Account { AccountNumber = num, AccountName = name, AccountType = typ };

			dataContext.Accounts.Add(account);
			dataContext.SaveChanges();
		}

		public void LoadAccounts()
		{
			var accounts = dataContext.Accounts.ToList();
			foreach (Account acct in accounts)
			{
				AccountSet.Add(acct);
			}
		}

		public void BuildEntries()
		{
			dataContext.Database.EnsureCreated();
		}

		private static void AddEntry(int num, string name, int typ)
		{
			//var entry = new Entry { Number = num, Name = name, Type = typ };
			//dataContext.Entries.Add(entry);
			//dataContext.SaveChanges();
		}

		public void BuildEntryLines()
		{
			dataContext.Database.EnsureCreated();
		}

		private static void AddEntryLine(int num, string name, int typ)
		{
			//var entryLine = new EntryLine { Number = num, Name = name, Type = typ };
			//dataContext.EntryLines.Add(entryLine);
			//dataContext.SaveChanges();
		}

	}
}


