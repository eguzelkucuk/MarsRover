namespace MarsRover.Case.Core
{
    /// <summary>
    /// Position Interface
    /// </summary>
    public interface IPosition
    {
        int GetXCoordinate();
        int GetYCoordinate();
        void XCoordinateIncrement();
        void YCoordinateIncrement();
        void XCoordinateDecrease();
        void YCoordinateDecrease();
    }

    /// <summary>
    /// Position class structure
    /// </summary>
    public class Position : IPosition
    {
        private int XCoordinate { get; set; }
        private int YCoordinate { get; set; }

      
        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }



        public int GetXCoordinate() => XCoordinate;
        public int GetYCoordinate() => YCoordinate;
        public void XCoordinateIncrement() => XCoordinate++;
        public void XCoordinateDecrease() => XCoordinate--;
        public void YCoordinateIncrement() => YCoordinate++;
        public void YCoordinateDecrease() => YCoordinate--;

    }

}
