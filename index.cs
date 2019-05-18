using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

public class Unit
{
  public int owner;
  public int unitId;
  public int x;
  public int y;
};

public class Player
{
  public static void Main(string[] args)
  {
    string[] inputs;
    int numberMineSpots = int.Parse(Console.ReadLine());
    // Console.Error.WriteLine("numberMineSpots" + numberMineSpots);
    for (int i = 0; i < numberMineSpots; i++)
    {
      inputs = Console.ReadLine().Split(' ');
      int x = int.Parse(inputs[0]);
      int y = int.Parse(inputs[1]);
    }

    bool isFirstTurn = true;

    // game loop
    while (true)
    {
      int gold = int.Parse(Console.ReadLine());
      int income = int.Parse(Console.ReadLine());
      int opponentGold = int.Parse(Console.ReadLine());
      int opponentIncome = int.Parse(Console.ReadLine());
      for (int i = 0; i < 12; i++)
      {
        string line = Console.ReadLine();
      }
      int buildingCount = int.Parse(Console.ReadLine());
      for (int i = 0; i < buildingCount; i++)
      {
        inputs = Console.ReadLine().Split(' ');
        int owner = int.Parse(inputs[0]);
        int buildingType = int.Parse(inputs[1]);
        int x = int.Parse(inputs[2]);
        int y = int.Parse(inputs[3]);
        Console.Error.WriteLine("owner " + owner + " buildingType " + buildingType + " x " + x + " y " + y);
      }
      int unitCount = int.Parse(Console.ReadLine());

      List<Unit> myUnits = new List<Unit>();

      for (int i = 0; i < unitCount; i++)
      {
        inputs = Console.ReadLine().Split(' ');
        int owner = int.Parse(inputs[0]);
        int unitId = int.Parse(inputs[1]);
        int level = int.Parse(inputs[2]);
        int x = int.Parse(inputs[3]);
        int y = int.Parse(inputs[4]);
        Console.Error.WriteLine("owner " + owner + " unitId " + unitId + " x " + x + " y " + y);
        Unit currentUnit = new Unit() { owner = owner, unitId = unitId, x = x, y = y };
        myUnits.Add(currentUnit);
      }

      if (isFirstTurn)
      {
        Console.WriteLine("WAIT; TRAIN 1 1 0;");
        isFirstTurn = false;
      }
      else
      {
        Console.WriteLine("MOVE 1 {0} {3}; MOVE 1 {1} {2};", myUnits[0].x, myUnits[0].x + 1, myUnits[0].y, myUnits[0].y + 1);
      }
    }
  }
}