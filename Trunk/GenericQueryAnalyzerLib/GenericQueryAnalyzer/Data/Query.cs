#region Using directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer.Data {
	public sealed class Query {
		private DbCommand _Command;

		#region public void Execute(DbCommand command)
		public void Execute(DbCommand command) {
			_Command = command;
			
			Thread t = new Thread(delegate() {
				try {
					DateTime startTime = DateTime.Now;
					DbConnection conn = _Command.Connection;
					bool isConnectionOpen = (conn.State == ConnectionState.Open);
					try {
						if (!isConnectionOpen)
							conn.Open();
					} catch (System.Exception ex) {
						throw new Exception("Error connecting to the database.", ex);
					}

					try {
						DbDataReader reader = _Command.ExecuteReader();
						DataTable table = new DataTable();
						table.Load(reader);

						TimeSpan executionTime = DateTime.Now - startTime;
						Decimal dExecutionTime = ((Decimal)0.001) * executionTime.Milliseconds;
						OnQueryCompleted(new QueryCompletedEventArgs(table, reader.RecordsAffected, dExecutionTime));
					} finally {
						if (!isConnectionOpen)
							conn.Close();
					}
				} catch (Exception ex) {
					OnExceptionThrown(new ThreadExceptionEventArgs(ex));
				}
			});
			t.Start();
		}
		#endregion

		#region public event QueryCompletedEventHandler QueryCompleted {get;set;}
		private event QueryCompletedEventHandler _QueryCompleted;
		public event QueryCompletedEventHandler QueryCompleted {
			add {
				_QueryCompleted += value;
			}
			remove {
				_QueryCompleted -= value;
			}
		}

		private void OnQueryCompleted(QueryCompletedEventArgs e) {
			if (_QueryCompleted != null) _QueryCompleted(this, e);
		}
		#endregion

		#region public event ThreadExceptionEventHandler ExceptionThrown {get;set;}
		private event ThreadExceptionEventHandler _ExceptionThrown;
		public event ThreadExceptionEventHandler ExceptionThrown {
			add {
				_ExceptionThrown += value;
			}
			remove {
				_ExceptionThrown -= value;
			}
		}

		private void OnExceptionThrown(ThreadExceptionEventArgs e) {
			if (_ExceptionThrown != null) _ExceptionThrown(this, e);
		}
		#endregion
	}
}
