namespace C43_G05_OOP03_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part1

            #region Q1
            // b) To define a blueprint for a class
            #endregion

            #region Q2
            // a) private
            #endregion

            #region Q3
            // b) No
            #endregion

            #region Q4
            //  b) Yes, interfaces can inherit from multiple interfaces 
            #endregion

            #region Q5
            //  d) implements
            #endregion

            #region Q6
            // a) Yes
            #endregion

            #region Q7
            // b) No, all members are implicitly public
            #endregion

            #region Q8
            //  b) To provide a clear separation between interface and class members
            #endregion

            #region Q9
            // b) No, interfaces cannot have constructors.
            #endregion

            #region Q10
            //  c) By separating interface names with commas. 
            #endregion

            #endregion

            #region Part2

            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();  // Output: Circle with Radius: 5, Area: 78.53981633974483

            IRectangle rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();

            #endregion
        }
    }
}
