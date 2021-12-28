using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Case.Core
{
    /// <summary>
    /// Directions enum
    /// </summary>
    public enum Directions { N, E, S, W }

    /// <summary>
    /// Rover Interface
    /// </summary>
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        Directions RoverDirection { get; set; }
        void Process(string commands);
        string ToString();
    }

    /// <summary>
    /// Rover class structure
    /// </summary>
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPosition RoverPosition { get; set; }
        public Directions RoverDirection { get; set; }


        public Rover(IPlateau roverPlateau, IPosition roverPosition, Directions roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }

        public void Process(string commands)
        {
            ArgumentNullException.ThrowIfNull(commands);

            commands.ToList().ForEach(x =>
            {
                if (x == 'L' || x == 'R')
                    Rotation(x);
                else if (x == 'M')
                    Move();
                else
                    throw new ArgumentException(commands);
            });
        }

        private void Rotation(char rotation) => RoverDirection = rotation == 'L'
                ? ((RoverDirection - 1) < Directions.N ? Directions.W : RoverDirection - 1)
                : ((RoverDirection + 1) > Directions.W ? Directions.N : RoverDirection + 1);

        private void Move()
        {
            if (RoverDirection == Directions.N)
                RoverPosition.YCoordinateIncrement();
            else if (RoverDirection == Directions.E)
                RoverPosition.XCoordinateIncrement();
            else if (RoverDirection == Directions.S)
                RoverPosition.YCoordinateDecrease();
            else if (RoverDirection == Directions.W)
                RoverPosition.XCoordinateDecrease();
        }

        public override string ToString() => $"{RoverPosition.GetXCoordinate()} {RoverPosition.GetYCoordinate()} {RoverDirection}";
    }
}
