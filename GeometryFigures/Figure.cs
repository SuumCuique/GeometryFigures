using System.Xml.Serialization;

namespace GeometryFigures {
    /// <summary>
    /// Abstract class for all figures
    /// </summary>
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Rectangle))]
    public abstract class Figure {
        public abstract double Area { get; set; }
        public abstract void CalculateArea();
        public double ReturnArea() {
            CalculateArea();
            return Area;
        }
    }
}