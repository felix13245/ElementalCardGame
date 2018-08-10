using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerField{



	Player player;
	CardStack grave;
	CardStack deck;
    Lane[] PlayerLanes;


	public PlayerField(Lane[] Lanes, Player p, CardStack d, CardStack g)
	{
		PlayerLanes = Lanes;
		player = p;
		deck = d;
		grave = g;
	}

}
