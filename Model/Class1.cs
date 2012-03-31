using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Model
{
    public class CommomRowDataModel
    {
        protected Hashtable data;
        public CommomRowDataModel()
        {
            data = new Hashtable();
        }
        public Object this[String ColumnName]
        {
            get
            {
                return data[ColumnCount];
            }
            set
            {
                data[ColumnCount] = value;
            }
        }
        public void SetValue(String ColumnName, Object value)
        {
            data[ColumnName] = value;
        }
        public Object GetValue(String ColumnName)
        {
            return data[ColumnName];
        }
        public int ColumnCount { get { return data.Count; } }
    }
}
