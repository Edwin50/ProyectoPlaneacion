using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.ComponentModel;
namespace Planeacion.LogicaNegocio
{
    public class ConvertLN
    {

     public  DataTable ToDataTable(IEnumerable<object> list){
         if (list == null ) {
             return null;
         }
            
         var lista = list.ToList();
         if (lista.Count == 0)
         {
             return null;
         }
         Type t = lista[0].GetType();

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(t);
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (object item in lista)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
