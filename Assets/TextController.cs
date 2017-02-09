using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {
		awake, compass, sweater, water, stand, hill, smoke, cabin, hostage, portal_0, 
		wiseman, goldcoins, stairs_0, shepard, cane, stairs_1, door_0, angel, gate, 
		stone, portal_1
		};
		
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.awake;
	}
	
	// Update is called once per frame
	void Update () {
		if 		(myState == States.awake) {Awake();} 
		else if (myState == States.compass) {Compass();}
		else if (myState == States.sweater) {Sweater();}
		else if (myState == States.water) {WaterBottle();}
		else if (myState == States.stand) {Stand();}
		else if (myState == States.hill) {Hill();}
		else if (myState == States.smoke) {Smoke();}
		else if (myState == States.cabin) {Cabin();} 
		else if (myState == States.hostage) {Hostage();} 
		else if (myState == States.portal_0) {Cloud();}
		else if (myState == States.wiseman) {Wiseman();}
		else if (myState == States.goldcoins) {Goldcoins();}
		else if (myState == States.stairs_0) {Stairs_0();}
		else if (myState == States.shepard) {Shepard();}
		else if (myState == States.cane) {Cane();}
		else if (myState == States.stairs_1) {Stairs_1();}
		else if (myState == States.door_0) {Door_0();}
		else if (myState == States.angel) {Angel();}
		else if (myState == States.gate) {Gate();}
		else if (myState == States.stone) {Stone();}
		else if (myState == States.portal_1) {Portal_1();}
	}
	
	void Awake () {
		text.text = "You wake up in the middle of the night in a desolate " +
					"forest. Your memory is fuzy and you have no idea how " +
					"you got there. Next to you, there is a compass, a sweater, " +
					"and a water bottle. You are deeply starving and dehydrated. " +
					"Your only focus is your yearn for survival. Where do " +
					"you go from here?\n\n" +
					"Press C to pick up the Compass, S for Sweater, and W for Water Bottle";
				
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.compass;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.sweater;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.water;} 		
	}
	
	void Compass() {
		text.text = "You pick up the compass only to realize that it is severly " +
					"cracked and utterly useless.\n\n" +
					"Press R to Return.";
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.awake;}
	}
	
	void Sweater() {
		text.text = "The sweater is a child's sweater. It is much to small and " +
					"doesn't serve a purpose.\n\n" +
					"Press R to Return.";
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.awake;}
	}
	
	void WaterBottle() {
		text.text = "The water bottle is full of fresh water.\n\n" +
					"Press D to Drink or press R to Return.";
		
		if 		(Input.GetKeyDown(KeyCode.D)) {myState = States.stand;} 
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.awake;}
	}
	
	void Stand() {
		text.text = "You take a large sip of water and are instantly replenished. " +
					"You stand up and observe your surroundings. You see a hill you " +
					"could climb to see if anything is around you, you see a smoke " +
					"signal far off in the distance, and you see a log cabin down a " +
					"beaten path.\n\n" +
					"Press H to climb the hill, S to follow the Smoke Signal, and C " +
					"to go to the log cabin.";
					
		if 		(Input.GetKeyDown(KeyCode.H)) {myState = States.hill;} 
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.smoke;} 
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cabin;}
	}
	
	void Hill() {
		text.text = "You climb to the top of the hill and see no other signs of life " +
					"other than the ever more prominent smoke signals. Something may " +
					"be over there.\n\n" +
					"Press R to Return.";
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.stand;}
	}
	
	void Smoke() {
		text.text = "You walk a long way to the smoke signal to find there a group " +
					"of people mingling around the fire.\n\n" +
					"Press T to go Talk to the people or press R to Return.";
		
		if 		(Input.GetKeyDown(KeyCode.T)) {myState = States.hostage;} 
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.stand;}
	}
	
	void Cabin() {
		text.text = "You walk to the log cabin and knock on the door. There is no " +
					"answer. You peek in the window to see no one is inside.\n\n" +
					"Press R to Return.";
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.stand;}
	}
	
	void Hostage() {
		text.text = "When you begin to talk to them, you find out they are not good " +
					"people. They say they have a portal to an alternative universes " +
					"and you must go in alone, collect the Emperor's stone, or you " +
					"will be killed.\n\n" +
					"Press E to Enter the portal!";
		
		if (Input.GetKeyDown(KeyCode.E)) {myState = States.portal_0;}
	}
	
	bool goldcoins = false;
	bool cane = false;
	bool key = false;
	
	void Cloud() {
		if (goldcoins == true) {
			text.text = "You walk back to where you began and see the stairway " +
						"awaiting you.\n\n" + 
						"Press S to climb the stairs.";
			
			if (Input.GetKeyDown(KeyCode.S)) {myState = States.stairs_0;}
		} else {
			text.text = "You land on a bed of clouds with a view of the sky all around " +
						"you. You expected hell and was given heaven. To your left, you " +
						"see what appears to be a wiseman in a toga with a long, grey " +
						"beard. To your right, you see a stairway that stretches for miles.\n\n" +
						"Press T to Talk to the wiseman or press S to climb the stairs.";
			
			if (Input.GetKeyDown(KeyCode.T)) {myState = States.wiseman;}		
			else if (Input.GetKeyDown(KeyCode.S)) {myState = States.stairs_0;}
		}
	}
	
	void Wiseman() {
		text.text = "You approach him and he presents to you a bag of gold " + 
					"coins.\n\n" +
					"Press T to Take the gold coins or press R to Return.";
		
		if (Input.GetKeyDown (KeyCode.T)) {myState = States.goldcoins;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.portal_0;}
	}
	
	void Goldcoins() {		
		goldcoins = true;
		text.text = "You took the gold coins and thanked the wiseman.\n\n" +
					"Press R to Return.";
			
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.portal_0;}		
	}
	
	void Stairs_0() {
		if (cane == true) {
			text.text = "You reach a platform again and the stairway awaits " +
						"you.\n\n" +
						"Press S to climb the Stairs or press R to Reutrn.";
						
			if (Input.GetKeyDown (KeyCode.S)) {myState = States.stairs_1;}
			else if (Input.GetKeyDown (KeyCode.R)) {myState = States.portal_0;}
		} else {
			text.text = "You climb the stairs and reach a platform. To your left, you " +
						"see a shepard. To your right, you see more stairway.\n\n" +
						"Press T to Talk to the shepard, press S to climb the " +
						"Stairs, or press R to Return.";
			
			if (Input.GetKeyDown (KeyCode.T)) {myState = States.shepard;}
			else if (Input.GetKeyDown (KeyCode.S)) {myState = States.stairs_1;}
			else if (Input.GetKeyDown (KeyCode.R)) {myState = States.portal_0;}
		}
	}
	
	void Shepard() {
		if (goldcoins == true) {
			text.text = "I see the wiseman gave you something, in return I also " +
						"have for you a Cane made entirely of marble.\n\n" +
						"Press T to Take the cane or press R to Return.";
						
			if (Input.GetKeyDown (KeyCode.T)) {myState = States.cane;}
			else if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_0;}
		} else {
			text.text = "You must first get the gold coins in order to receive " +
						"your gift.\n\n" +
						"Press R to Return.";
						
			if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_0;}
		}
	}
	
	void Cane() {
		cane = true;
		text.text = "You took the cane and the shepard said you must be on your " +
					"way.\n\n" +
					"Press R to Return.";
					
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_0;}
	}
	
	void Stairs_1() {
		if (key == true) {
			text.text = "You stand beneath the sky high gate as it awaits you.\n\n" +
						"Press G to ender the Gate or press R to Return.";
						
			if (Input.GetKeyDown(KeyCode.G)) {myState = States.gate;}
			else if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_0;}
		} else {
			text.text = "You reach another platform. To your left, there is a subtle " +
						"white door. To your right, there is a massively beautiful gate.\n\n" +
						"Press D to enter the Door, press G to enter the Gate, " +
						"or Press R to Return.";
			
			if (Input.GetKeyDown(KeyCode.D)) {myState = States.door_0;}
			else if (Input.GetKeyDown(KeyCode.G)) {myState = States.gate;}
			else if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_0;}
		}
	}
	
	void Gate() {
		if (key == true) {
			text.text = "You eagerly walk towards the gate, knowing you destiny " +
						"is on the other side.\n\n" +
						"Press O to Open the gate or press R to Return.";
		
			if (Input.GetKeyDown(KeyCode.O)) {myState = States.stone;}
			else if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_1;}
		} else {
			text.text = "The gate is locked and needs a key in order to open.\n\n" +
						"Press R to Return.";
						
			if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_1;}
		}
	}
	
	void Door_0() {
		if (cane == true) {
			myState = States.angel;
		
			if (Input.GetKeyDown(KeyCode.Return)) {myState = States.angel;}
		} else {
			text.text = "The door is locked. You knock on the door and you hear " +
						"a voice on the side say, 'Come back after you have " +
						"collected the cane and the gold coins'.\n\n" +
						"Press R to Return.";
			
			if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_1;}
		}
	}
	
	void Angel(){
		key = true;
		text.text = "The door slowly swings open and you see an angel to " +
					"greet you. The angel is very happy to meet you, almost " +
					"like you were destined to be there. She hands you a " +
					"large gold key and says, 'This is the answer to all " +
					"your problems.'\n\n" +
					"Press R to Return.";
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.stairs_1;}			
	}
	
	void Stone() {
		text.text = "Congraduations! Upon entering the gate you find the " +
					"hidden Emperor's Stone. You grab the stone and a portal " +
					"appears.\n\n" +
					"Press P to enter the Portal.";
					
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.portal_1;}
	}
	
	void Portal_1() {
		text.text = "You have been safely transported back home and escaped " +
					"death!\n\n" +
					"Press P to Play again.";
					
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.awake;}
	}	
}
