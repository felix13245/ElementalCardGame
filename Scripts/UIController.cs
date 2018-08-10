using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {



	[SerializeField]
	int boardwitdth;
	[SerializeField]
	int rSlotCount=4;
	[SerializeField]
	int mSlotCount=7;
	[SerializeField]
	GameObject minionSlots;
	[SerializeField]
	GameObject relicSlots;
	[SerializeField]
	GameObject deck;
	[SerializeField]
	GameObject grave;
	int i ;

	ISlot[] minions1;
	ISlot[] minions2;
	ISlot[] relics1;
	ISlot[] relics2;
	CardStack deck1;
	CardStack deck2;
	CardStack grave1 ;
	CardStack grave2 ;
	Player player1 ;
	Player player2 ;
//	Board board = new Board();
	Lane mLane1;	
	Lane mLane2;	
	Lane rLane1 ;	
	Lane rLane2;	

	PlayerField playerfield1;
	PlayerField playerfield2;
	Board board;


	void Start ()
	{
		CreateSlots ();
		CreateLanes ();
		//GetDecks();
		CreateUniques ();
		CreateBoard();
		InstantiateBoard (); 


	}

	void CreateSlots()
	{
		minions1 = new ISlot[mSlotCount];
		minions2 = new ISlot[mSlotCount];
		relics1 = new ISlot[rSlotCount];
		relics2 = new ISlot[rSlotCount];
			for (i = 0; i < mSlotCount; i++)
			{
			minions1[i]= new MinionSlot();
			}
			for (int i = 0; i < rSlotCount; i++)
			{
			relics1[i]= new RelicSlot();
			}
			for (int i = 0; i < mSlotCount; i++)
			{
			minions1[i]= new MinionSlot();
			}
			for (int i = 0; i < rSlotCount; i++)
			{
			relics1[i]= new RelicSlot();
			}


			
	}
	void CreateLanes()
	{
	     mLane1 =new Lane(minions1);	
		 mLane2 =new Lane(minions2);	
		 rLane1 =new Lane(relics1);	
		 rLane2 =new Lane(relics2);	
	}
	void CreateUniques()
	{
		 deck1 = new CardStack (false);
		 deck2 = new CardStack (false);
		 grave1 = new CardStack (true);
		 grave2 = new CardStack (true);
		 player1 = new Player (50);
		 player2 = new Player (50);

	}
	void CreateBoard()
	{
		Lane[] lanearray1 = new Lane[] { mLane1, rLane1};
		playerfield1 = new PlayerField (lanearray1,player1,deck1,grave1);

		Lane[] lanearray2 = new Lane[] { mLane2, rLane2};
		playerfield2 = new PlayerField (lanearray2,player2,deck2,grave2);
		PlayerField[] playerFieldArray = new PlayerField[] { playerfield1, playerfield2};


		board = new Board (playerFieldArray);
	}
	void InstantiateBoard()
	{
		
	}


}

