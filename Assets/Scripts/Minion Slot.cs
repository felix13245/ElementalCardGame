using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSlot :ISlot {

	MinionSlot(GameObject x)
	{
		slot = x;
	}

	public GameObject slot ;
}
