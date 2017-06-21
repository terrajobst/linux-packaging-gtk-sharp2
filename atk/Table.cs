// This file was auto-generated at one time, but is hardcoded here as part of the fix
// for the AtkTable interface;  see https://bugzilla.novell.com/show_bug.cgi?id=512477
// The generated code may have been modified as part of this fix; see atk-table.patch

namespace Atk {

	using System;

#region Autogenerated code
	public interface Table : GLib.IWrapper {

		event System.EventHandler ColumnReordered;
		event Atk.ColumnDeletedHandler ColumnDeleted;
		event System.EventHandler RowReordered;
		event Atk.ColumnInsertedHandler ColumnInserted;
		event System.EventHandler ModelChanged;
		event Atk.RowInsertedHandler RowInserted;
		event Atk.RowDeletedHandler RowDeleted;
		int NRows { 
			get;
		}
		bool AddRowSelection(int row);
		int GetColumnExtentAt(int row, int column);
		Atk.Object GetColumnHeader(int column);
		bool IsSelected(int row, int column);
		Atk.Object Summary { 
			get; set;
		}
		string GetColumnDescription(int column);
		bool AddColumnSelection(int column);
		void SetRowHeader(int row, Atk.Object header);
		string GetRowDescription(int row);
		Atk.Object RefAt(int row, int column);
		void SetColumnDescription(int column, string description);
		int GetIndexAt(int row, int column);
		Atk.Object GetRowHeader(int row);
		bool IsColumnSelected(int column);
		int [] SelectedRows { get; }
		void SetRowDescription(int row, string description);
		bool IsRowSelected(int row);
		int GetRowExtentAt(int row, int column);
		int [] SelectedColumns { get; }
		int GetColumnAtIndex(int index_);
		int GetRowAtIndex(int index_);
		Atk.Object Caption { 
			get; set;
		}
		int NColumns { 
			get;
		}
		bool RemoveRowSelection(int row);
		bool RemoveColumnSelection(int column);
		void SetColumnHeader(int column, Atk.Object header);
	}

	[GLib.GInterface (typeof (TableAdapter))]
	public interface TableImplementor : GLib.IWrapper {

		Atk.Object RefAt (int row, int column);
		int GetIndexAt (int row, int column);
		int GetColumnAtIndex (int index_);
		int GetRowAtIndex (int index_);
		int NColumns { get; }
		int NRows { get; }
		int GetColumnExtentAt (int row, int column);
		int GetRowExtentAt (int row, int column);
		Atk.Object Caption { get; set; }
		string GetColumnDescription (int column);
		Atk.Object GetColumnHeader (int column);
		string GetRowDescription (int row);
		Atk.Object GetRowHeader (int row);
		Atk.Object Summary { get; set; }
		void SetColumnDescription (int column, string description);
		void SetColumnHeader (int column, Atk.Object header);
		void SetRowDescription (int row, string description);
		void SetRowHeader (int row, Atk.Object header);
		int [] SelectedColumns { get; }
		int [] SelectedRows { get; }
		bool IsColumnSelected (int column);
		bool IsRowSelected (int row);
		bool IsSelected (int row, int column);
		bool AddRowSelection (int row);
		bool RemoveRowSelection (int row);
		bool AddColumnSelection (int column);
		bool RemoveColumnSelection (int column);
	}
#endregion
}