#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer.Data {
	public delegate void ExecuteQueryEventHandler(object sender, ExecuteQueryEventArgs e);

	public sealed class ExecuteQueryEventArgs {
		public ExecuteQueryEventArgs(string connectionString, string queryString) {
			if (connectionString == null) throw new ArgumentNullException("connectionString");
			if (queryString == null) throw new ArgumentNullException("queryString");
			
			_ConnectionString = connectionString;
			_QueryString = queryString;
		}

		#region Properties
		#region public string ConnectionString {get;}
		private string _ConnectionString;

		public string ConnectionString {
			get { return _ConnectionString; }
		}
		#endregion

		#region public string QueryString {get;}
		private string _QueryString;

		public string QueryString {
			get { return _QueryString; }
		}
		#endregion
		#endregion
	}
}
