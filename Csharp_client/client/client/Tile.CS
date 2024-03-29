using System;
using System.Runtime.InteropServices;


///A basic tile
public class Tile: Mappable 
{
  public IntPtr ptr;
  int ID;
  int iteration;
  
  public Tile()
  {
      throw new System.ArgumentException("Default constructor is required by C# but not appropriate for use in this context.");
  }
  
  public Tile(IntPtr p)
  {
    ptr = p;
    ID = Client.tileGetId(ptr);
    iteration = BaseAI.iteration;
  }

public override bool validify()
  {
    if(iteration == BaseAI.iteration) return true;
    for(int i = 0; i < BaseAI.tiles.Length; i++)
    {
      if(BaseAI.tiles[i].ID == ID)
      {
        ptr = BaseAI.tiles[i].ptr;
        iteration = BaseAI.iteration;
        return true;
      }
    }
    throw new ExistentialError();
  }
    
    //commands
    
    
    //getters
    
  ///Unique Identifier
  public int getId()
  {
    validify();
    return Client.tileGetId(ptr);
  }
  ///The X position of this object.  X is horizontal, with 0,0 as the top left corner
  public int getX()
  {
    validify();
    return Client.tileGetX(ptr);
  }
  ///The Y position of this object.  Y is vertical, with 0,0 as the top left corner
  public int getY()
  {
    validify();
    return Client.tileGetY(ptr);
  }
  ///land = 0, water = 1
  public int getType()
  {
    validify();
    return Client.tileGetType(ptr);
  }

}
