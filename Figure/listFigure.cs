using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class listFigure
    {
        List<Figure> list;

        public List<Figure>List { get { return list; } }

        public double SumSquare 
        {
            get 
            {
                double sumSquare = 0;
                foreach(Figure fig in list)
                {
                    sumSquare += fig.getSqare();
                }
                return sumSquare;
            }
        }

        public void AddFigure(Figure fig)
        {
            list.Add(fig);
        }

        public void RemoteFigure(Figure fig)
        {
            list.Remove(fig);
        }

        public void InfoFigure()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list);
            }
        }

        public listFigure(List<Figure> list)
        {
            this.list = list;
        }
    }
}
