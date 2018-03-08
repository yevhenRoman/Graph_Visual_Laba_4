using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Visual_Laba_3
{
    interface IDrawable
    {
        void Draw(List<Tuple<string, string>> list, System.Windows.Forms.DataGridView gridView);
    }
}
