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
  public int id;
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
        // Console.Error.WriteLine("i: " + line);
      }
      int buildingCount = int.Parse(Console.ReadLine());

      List<Unit> myBuildingUnits = new List<Unit>();

      for (int i = 0; i < buildingCount; i++)
      {
        inputs = Console.ReadLine().Split(' ');
        int owner = int.Parse(inputs[0]);
        if (owner == 0)
        {
          int buildingType = int.Parse(inputs[1]);
          int x = int.Parse(inputs[2]);
          int y = int.Parse(inputs[3]);
          Unit currentUnit = new Unit() { owner = owner, id = buildingType, x = x, y = y };
          myBuildingUnits.Add(currentUnit);
        }
      }

      int homeXCoord = myBuildingUnits[0].x;
      Console.Error.WriteLine("homeXCoord " + homeXCoord);

      int unitCount = int.Parse(Console.ReadLine());

      List<Unit> myArmyUnits = new List<Unit>();

      for (int i = 0; i < unitCount; i++)
      {
        inputs = Console.ReadLine().Split(' ');
        int owner = int.Parse(inputs[0]);
        if (owner == 0)
        {
          int unitId = int.Parse(inputs[1]);
          int level = int.Parse(inputs[2]);
          int x = int.Parse(inputs[3]);
          int y = int.Parse(inputs[4]);
          Console.Error.WriteLine("owner " + owner + " unitId " + unitId + " x " + x + " y " + y);
          Unit currentUnit = new Unit() { owner = owner, id = unitId, x = x, y = y };
          myArmyUnits.Add(currentUnit);
        }
      }

      if (isFirstTurn)
      {
        int xCoord = homeXCoord == 0 ? 1 : 10;
        Console.WriteLine("TRAIN 1 {1} {0}; TRAIN 1 {0} {1};", xCoord, homeXCoord);
        isFirstTurn = false;
      }
      else
      {
        int destinationXCoord = homeXCoord == 0 ? myArmyUnits[0].x + 1 : myArmyUnits[0].x - 1;
        int destinationYCoord = homeXCoord == 0 ? myArmyUnits[0].y + 1 : myArmyUnits[0].y - 1;

        if (destinationXCoord <= 11 && destinationXCoord >= 0 && destinationYCoord <= 11 && destinationYCoord >= 0)
        {
          Console.WriteLine("MOVE {0} {1} {4}; MOVE {0} {2} {3};", myArmyUnits[0].id, myArmyUnits[0].x, destinationXCoord, myArmyUnits[0].y, destinationYCoord);
        } else
        {
          Console.WriteLine("WAIT");
        }
      }
    }
  }
}