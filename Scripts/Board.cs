using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board{

	PlayerField[] fields = new PlayerField[2];


	public Board (PlayerField[] players)
	{
		for (int i = 0;i < 2; i++) 
		{
			fields [i] = players [i];
		}
	}
}