namespace Lab4
{
    public abstract class GeomatricObject
    {
        protected string color;
        protected double weight;

        protected GeomatricObject()
        {
            color = "white";
            weight = 1.0;
        }

        protected GeomatricObject(string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }

        public string PColor
        {
            get { return color; }
            set { color = value; }
        }

        public double PWight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract string toString();
        public abstract double findArea();
        public abstract double findPerimeter();
    }
}