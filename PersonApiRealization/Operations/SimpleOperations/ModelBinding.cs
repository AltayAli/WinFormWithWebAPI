using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApiRealization.Operations.SimpleOperations
{
    public  class ModelBinding<T> where T:class ,new()
    {
        Control mainCorntrol { get; set; }
        public  ModelBinding(Control control)
        {
            mainCorntrol = control;
        }

        public T BindimgOperation()
        {
            T obj = new T();
            foreach(var item in obj.GetType().GetProperties())
            {
                
                var subControlsList = mainCorntrol.Controls;
                foreach(var subcontrol in subControlsList)
                {
                   if(subcontrol is TextBox)
                    {
                        var control = (subcontrol as TextBox);
                        if (control.Name.Contains(item.Name))
                        {
                            item.SetValue(obj,control.Text);
                        }
                    }
                }
            }
            return obj;
        }
        
    }
}
