using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace TriviaConcurso.Herramientas
{
    public static class Extensiones
    {
        private static Random rng = new Random();
        public static DataTable ComoDataTable<T>(this IEnumerable<T> data)
        {
            try {
                if (data == null || data.Count() == 0) return null; 
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(data.ToList().FirstOrDefault().GetType());
                var table = new DataTable();
                foreach (PropertyDescriptor prop in properties)
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
                return table;
            }
            catch 
            {
            }
            return null;
        }

        public static T TomaAleatorio<T>(this List<T> origen)
        {
           if (origen.Count==0) return default;
            rng.Next(origen.Count);
            rng.Next(origen.Count);
            rng.Next(origen.Count);
            return origen[rng.Next(origen.Count)];
        }

        
    }
}
