// Copyright (c) 2004, Brian Takita All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//
// * Redistributions of source code must retain the above copyright notice, this
//   list of conditions and the following disclaimer.
// * Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution.
// * Neither the name of NetAdventurer nor the names of its contributors may
//   be used to endorse or promote products derived from this software without
//   specific prior written permission. 
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
// ARE DISCLAIMED. IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
// LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
// OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
// DAMAGE.
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
