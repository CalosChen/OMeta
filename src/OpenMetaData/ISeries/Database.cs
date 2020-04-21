using System;
using System.Data;
using System.Data.OleDb;

namespace OMeta.ISeries
{
  
	public class ISeriesDatabase : Database
	{
		public ISeriesDatabase()
		{

		}

		override public string Alias
		{
			get
			{
				return _name;
			}
		}

		override public string Name
		{
			get
			{
				return _name;
			}
		}

		override public string Description
		{
			get
			{
				return _desc;
			}
		}

		internal string _name = "";
		internal string _desc = "";
	}
}
