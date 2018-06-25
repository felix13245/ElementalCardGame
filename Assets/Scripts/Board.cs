using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board{


	public Board (PlayerField[] players)
	{
		fields = players;
	}


	PlayerField[] fields = new PlayerField[2];
}
