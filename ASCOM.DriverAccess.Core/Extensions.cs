using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ASCOM.DriverAccess
{
    public static class Extensions
    {
        public static ArrayList ToArrayList(this IEnumerable enumerable)
        {
            var templist = new ArrayList();

            foreach (var item in enumerable)
            {
                templist.Add(item);
            }
            return templist;
        }

        public static ArrayList ComObjToArrayList(this object obj)
        {
            return obj as ArrayList ?? ((IEnumerable)obj).ToArrayList();
        }
    }
}
