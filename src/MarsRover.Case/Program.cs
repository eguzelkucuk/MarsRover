using MarsRover.Case.Core;

Console.WriteLine("Test Input:");
Console.WriteLine("5 5");
Console.WriteLine("1 2 N");
Console.WriteLine("LMLMLMLMM");
Console.WriteLine("3 3 E");
Console.WriteLine("MMRMMRMRRM");
Console.WriteLine();

//Initial Rover Position
Plateau plateauOne = new(new Position(5, 5));
Rover firstRover = new(plateauOne, new Position(1, 2), Directions.N);
firstRover.Process("LMLMLMLMM");

//New Rover Create and Change Position
Plateau plateauTwo = new(new Position(5, 5));
Rover secondRover = new(plateauTwo, new Position(3, 3), Directions.E);
secondRover.Process("MMRMMRMRRM");

Console.WriteLine("Expected Output:");
Console.WriteLine(firstRover.ToString());
Console.WriteLine(secondRover.ToString());
Console.WriteLine();

Console.ReadLine();