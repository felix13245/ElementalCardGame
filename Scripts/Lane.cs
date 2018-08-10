using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane {

	 ISlot[] slots ;

	public ISlot[] Slots
	{
		get {
			return slots;
		}
	}

 public Lane (ISlot[] slot)
	{
		slots = slot;

	}
}

public class CardStack
{

	bool checkable;
	//List <Card>;

	public CardStack(bool c)
	{
		checkable = c;
	}

}





public class Player  {

	int hitpoints;
	public Player (int hp){
		hitpoints = hp;
	}
}
