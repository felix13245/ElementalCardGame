using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicSlot : ISlot {

	RelicSlot(GameObject x)
	{
		gameObject = x;
	}
	public GameObject gameObject;

}
