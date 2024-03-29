using System;
using System.Runtime.InteropServices;


///An object that exists on the grid
public abstract class Mappable
{
  public IntPtr ptr;
  int ID;
  int iteration;
  
  public Mappable()
  {
      throw new System.ArgumentException("Default constructor is required by C# but not appropriate for use in this context.");
  }
  
  public Mappable(IntPtr p)
  {
    ptr = p;
    ID = Client.mappableGetId(ptr);
    iteration = BaseAI.iteration;
  }

public abstract bool validify();
    
    //commands
    
    
    //getters
    
  ///Unique Identifier
  public int getId()
  {
    validify();
    return Client.mappableGetId(ptr);
  }
  ///The X position of this object.  X is horizontal, with 0,0 as the top left corner
  public int getX()
  {
    validify();
    return Client.mappableGetX(ptr);
  }
  ///The Y position of this object.  Y is vertical, with 0,0 as the top left corner
  public int getY()
  {
    validify();
    return Client.mappableGetY(ptr);
  }

}
