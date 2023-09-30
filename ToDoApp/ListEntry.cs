using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ToDoApp
{
    public class ListEntry
    {
        private bool? _completed = false;
        private string _entry = "";
        private static List<ListEntry> _toDoList = new List<ListEntry>();
        private List<string> _saveList = new List<string>();


        public string Entry 
        { 
            get { return _entry; } 
            
            set { _entry = value; } 
        }
        
        public bool? Completed 
        { 
            get { return _completed; } 
            
            set { _completed = value; } 
        }
        

        public static List<ListEntry> ToDoList
        {
            get { return _toDoList; }
            set { _toDoList = value; }
        }

        public List<string> SaveList
        {
            get { return _saveList; }
            set { _saveList = value; }
        }

        public ListEntry() { }

        public ListEntry(string entry, bool completed)
        {
            this._entry = entry;
            this._completed = completed;
        }

        private void UpdateSaveList()
        {
          
            foreach (var toDo in ToDoList)
            {
                if (toDo.ToString() != null)
                {
                    _saveList.Add(toDo.ToString());
                }
                
            }
        }
    }
}
