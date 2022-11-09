using Figure;
using System;

Circle cir = new Circle();
cir.Name = "circle";
cir.ColorFigure = "red";
cir.radiys = 15;
cir.Print();

Rectangel rec = new Rectangel();
rec.Name = "rectangel";
rec.ColorFigure = "yellow";
rec.radiys = 21;
rec.Print();

listFigure lF = new listFigure(new List<Figure>());
lF.AddFigure(rec);
lF.AddFigure(cir);
double sumSquare = lF.SumSquare;
lF.InfoFigure();
