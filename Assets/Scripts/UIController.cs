using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {



	[SerializeField]
	int boardwitdth;
	[SerializeField]
	int rSlotCount=0;
	[SerializeField]
	int mSlotCount=0;
	[SerializeField]
	GameObject minionSlots;
	[SerializeField]
	GameObject relicSlots;
	[SerializeField]
	GameObject deck;
	[SerializeField]
	GameObject grave;
	int i ;
	RelicSlot relicSlot = new RelicSlot();
	MinionSlot minionSlot = new MinionSlot();
//	Board board = new Board();
	Lane lane =new Lane();




	void Start ()
	{




		for (i = 0; i < rSlotCount; i++)

		{
			//relicslots
		Instantiate (relicSlots,transform);
		}





		for (i = 0; i < mSlotCount; i++)

		{
			//relicslots
			Instantiate (minionSlots,transform);
		}










































	}
	

	void Update () 
	{







	}
}
