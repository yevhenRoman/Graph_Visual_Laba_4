using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Visual_Laba_3
{
    class DrawGraphics : IDrawable
    {
        private PointF[] GeneratePointsFArray(List<Tuple<string, string>> list)
        {
            PointF[] array = new PointF[list.Count];

            for(int i = 0; i < list.Count; ++i)
            {
                array[i].X = float.Parse(list.ElementAt(i).Item1);
                array[i].Y = float.Parse(list.ElementAt(i).Item2);
            }

            return array;
        }

        public void Draw(List<Tuple<string, string>> list, DataGridView gridView)
        {
            Graphics g = gridView.CreateGraphics();
            g.Clear(gridView.BackgroundColor);  
            g.DrawCurve(Pens.Red, GeneratePointsFArray(list));
            g.Dispose();
        }
    }
}
