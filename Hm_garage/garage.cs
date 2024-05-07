using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hm_garage
{
    public class garage
    {
        public class Garage
        {
            private List<auto> list;
            // свойство, возращающее список
            //public List<Auto> List { get {  return list; } }
            public auto this[int index]
            {
                get
                {
                    if (index < 0 || index >= list.Count)
                    {
                        return null;
                    }
                    else
                    {
                        return list[index];
                    }

                }
            }
            public Garage()
            {
                list = new List<auto>();
            }
            public void AddAuto(auto mobile)
            {
                list.Add(mobile);
            }


            public void erase_auto(int index)
            {
                list.RemoveAt(index);
            }

            public List<auto> List { get { return list; } }


        }
    }
}
