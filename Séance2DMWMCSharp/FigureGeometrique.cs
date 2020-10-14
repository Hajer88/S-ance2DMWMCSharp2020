using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Seance2DMWMCSharp
{
    class FigureGeometrique
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public void dessiner() { }
        public void ChangerTaille() { }

    }
    class CercleDansCarre : FigureGeometrique
    {
        Rectangle r = new Rectangle();
        Cercle c = new Cercle();
    }
    class Cercle : FigureGeometrique
    {
        public int Rayon { get; set; }
        public void GetRayon() { }
        public void SetNouvRayon() { }
    }
    class Rectange :FigureGeometrique
    {
        public int Largeur { get; set; }
        public int hauteur { get; set; }
        public void getLArgeur() { }
        public void setNouvelleLargeur() { }
        public void setNouvlleHauteur() { }
    }
}
