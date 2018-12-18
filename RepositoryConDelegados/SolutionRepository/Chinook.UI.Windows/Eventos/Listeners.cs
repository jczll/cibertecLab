using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.UI.Windows.Eventos
{
    public class Listeners
    {
        public delegate void AfterSelectedItemHandler(Object obj);
        public delegate void AfterSavedItemHandler(Object obj);
    }
}
