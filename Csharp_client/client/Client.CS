using System;
using System.Runtime.InteropServices;

public class Client {
  [DllImport("client")]
  public static extern IntPtr createConnection();
  [DllImport("client")]
  public static extern int serverConnect(IntPtr connection, string host, string port);

  [DllImport("client")]
  public static extern int serverLogin(IntPtr connection, string username, string password);
  [DllImport("client")]
  public static extern int createGame(IntPtr connection);
  [DllImport("client")]
  public static extern int joinGame(IntPtr connection, int id);

  [DllImport("client")]
  public static extern void endTurn(IntPtr connection);
  [DllImport("client")]
  public static extern void getStatus(IntPtr connection);

  [DllImport("client")]
  public static extern int networkLoop(IntPtr connection);


    //commands
  [DllImport("client")]
  public static extern int unitMove(IntPtr self, int x, int y);
  [DllImport("client")]
  public static extern int unitTalk(IntPtr self, string message);
  [DllImport("client")]
  public static extern int unitAttack(IntPtr self, IntPtr Target);
  [DllImport("client")]
  public static extern int pirateMove(IntPtr self, int x, int y);
  [DllImport("client")]
  public static extern int pirateTalk(IntPtr self, string message);
  [DllImport("client")]
  public static extern int pirateAttack(IntPtr self, IntPtr Target);
  [DllImport("client")]
  public static extern int piratePickupTreasure(IntPtr self, int amount);
  [DllImport("client")]
  public static extern int pirateDropTreasure(IntPtr self, int amount);
  [DllImport("client")]
  public static extern int pirateBuildPort(IntPtr self);
  [DllImport("client")]
  public static extern int portCreatePirate(IntPtr self);
  [DllImport("client")]
  public static extern int portCreateShip(IntPtr self);
  [DllImport("client")]
  public static extern int shipMove(IntPtr self, int x, int y);
  [DllImport("client")]
  public static extern int shipTalk(IntPtr self, string message);
  [DllImport("client")]
  public static extern int shipAttack(IntPtr self, IntPtr Target);

    //accessors
  [DllImport("client")]
  public static extern int getTurnNumber(IntPtr connection);
  [DllImport("client")]
  public static extern int getPlayerID(IntPtr connection);
  [DllImport("client")]
  public static extern int getGameNumber(IntPtr connection);
  [DllImport("client")]
  public static extern int getPlayer0Time(IntPtr connection);
  [DllImport("client")]
  public static extern int getPlayer1Time(IntPtr connection);

  [DllImport("client")]
  public static extern IntPtr getPirate(IntPtr connection, int num);
  [DllImport("client")]
  public static extern int getPirateCount(IntPtr connection);
  [DllImport("client")]
  public static extern IntPtr getPort(IntPtr connection, int num);
  [DllImport("client")]
  public static extern int getPortCount(IntPtr connection);
  [DllImport("client")]
  public static extern IntPtr getShip(IntPtr connection, int num);
  [DllImport("client")]
  public static extern int getShipCount(IntPtr connection);
  [DllImport("client")]
  public static extern IntPtr getTile(IntPtr connection, int num);
  [DllImport("client")]
  public static extern int getTileCount(IntPtr connection);
  [DllImport("client")]
  public static extern IntPtr getTreasure(IntPtr connection, int num);
  [DllImport("client")]
  public static extern int getTreasureCount(IntPtr connection);


    //getters
  [DllImport("client")]
  public static extern int mappableGetId(IntPtr ptr);
  [DllImport("client")]
  public static extern int mappableGetX(IntPtr ptr);
  [DllImport("client")]
  public static extern int mappableGetY(IntPtr ptr);

  [DllImport("client")]
  public static extern int unitGetId(IntPtr ptr);
  [DllImport("client")]
  public static extern int unitGetX(IntPtr ptr);
  [DllImport("client")]
  public static extern int unitGetY(IntPtr ptr);
  [DllImport("client")]
  public static extern int unitGetOwner(IntPtr ptr);
  [DllImport("client")]
  public static extern int unitGetHealth(IntPtr ptr);
  [DllImport("client")]
  public static extern int unitGetStrength(IntPtr ptr);
  [DllImport("client")]
  public static extern int unitGetHasMoved(IntPtr ptr);
  [DllImport("client")]
  public static extern int unitGetHasAttacked(IntPtr ptr);

  [DllImport("client")]
  public static extern int pirateGetId(IntPtr ptr);
  [DllImport("client")]
  public static extern int pirateGetX(IntPtr ptr);
  [DllImport("client")]
  public static extern int pirateGetY(IntPtr ptr);
  [DllImport("client")]
  public static extern int pirateGetOwner(IntPtr ptr);
  [DllImport("client")]
  public static extern int pirateGetHealth(IntPtr ptr);
  [DllImport("client")]
  public static extern int pirateGetStrength(IntPtr ptr);
  [DllImport("client")]
  public static extern int pirateGetHasMoved(IntPtr ptr);
  [DllImport("client")]
  public static extern int pirateGetHasAttacked(IntPtr ptr);

  [DllImport("client")]
  public static extern int portGetId(IntPtr ptr);
  [DllImport("client")]
  public static extern int portGetX(IntPtr ptr);
  [DllImport("client")]
  public static extern int portGetY(IntPtr ptr);
  [DllImport("client")]
  public static extern int portGetOwner(IntPtr ptr);

  [DllImport("client")]
  public static extern int shipGetId(IntPtr ptr);
  [DllImport("client")]
  public static extern int shipGetX(IntPtr ptr);
  [DllImport("client")]
  public static extern int shipGetY(IntPtr ptr);
  [DllImport("client")]
  public static extern int shipGetOwner(IntPtr ptr);
  [DllImport("client")]
  public static extern int shipGetHealth(IntPtr ptr);
  [DllImport("client")]
  public static extern int shipGetStrength(IntPtr ptr);
  [DllImport("client")]
  public static extern int shipGetHasMoved(IntPtr ptr);
  [DllImport("client")]
  public static extern int shipGetHasAttacked(IntPtr ptr);

  [DllImport("client")]
  public static extern int tileGetId(IntPtr ptr);
  [DllImport("client")]
  public static extern int tileGetX(IntPtr ptr);
  [DllImport("client")]
  public static extern int tileGetY(IntPtr ptr);
  [DllImport("client")]
  public static extern int tileGetType(IntPtr ptr);

  [DllImport("client")]
  public static extern int treasureGetId(IntPtr ptr);
  [DllImport("client")]
  public static extern int treasureGetX(IntPtr ptr);
  [DllImport("client")]
  public static extern int treasureGetY(IntPtr ptr);
  [DllImport("client")]
  public static extern int treasureGetPirateID(IntPtr ptr);
  [DllImport("client")]
  public static extern int treasureGetAmount(IntPtr ptr);


    //properties

}
