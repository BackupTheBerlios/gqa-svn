#region Using directives

using System;
using System.Data;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer.Data {
	public delegate void QueryCompletedEventHandler(object sender, QueryCompletedEventArgs e);

	public sealed class QueryCompletedEventArgs {
		public QueryCompletedEventArgs(DataTable table, int recordsAffected, decimal executionTime) {
			if (table == null) throw new ArgumentNullException("table");
			_Table = table;
			_RecordsAffected = recordsAffected;
			_ExecutionTime = executionTime;
		}

		#region public DataTable Table {get;}
		private DataTable _Table;

		public DataTable Table {
			get { return _Table; }
		}
		#endregion

		#region public int RecordsAffected {get;}
		private int _RecordsAffected;

		public int RecordsAffected {
			get { return _RecordsAffected; }
		}
		#endregion

		#region public Decimal ExecutionTime {get;}
		private Decimal _ExecutionTime;

		public Decimal ExecutionTime {
			get { return _ExecutionTime; }
		}
		#endregion

	}
}
