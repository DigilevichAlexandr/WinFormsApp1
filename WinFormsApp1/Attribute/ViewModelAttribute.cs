using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Attribute
{
    [global::System.AttributeUsage(AttributeTargets.Class,
                                Inherited = false, AllowMultiple = false)]
    sealed class ViewModelAttribute : System.Attribute
    {
        public ViewModelAttribute() { }
        public ViewModelAttribute(bool Activated)
        {
            this.Activated = Activated;
        }
        public bool Activated { get; set; }
    }
}
