using UnityEngine;
using System.Collections;

public class MovePlayers : MonoBehaviour {

	public float moveSpeed = 05f;
	public VJHandler jsMovement;
	
	private Vector3 direction;
	private float xMin,xMax,yMin,yMax;
	
	void Update () {
		
		direction = jsMovement.InputDirection; //InputDirection can be used as per the need of your project
		
		if(direction.magnitude != 0){
		
			transform.position += direction * moveSpeed;
			transform.position = new Vector3(Mathf.Clamp(transform.position.x,xMin,xMax),Mathf.Clamp(transform.position.y,yMin,yMax),0f);//to restric movement of player
		}	
	}	
	
	void Start(){
	
		//Initialization of boundaries
		xMax = Screen.width - 50; // I used 50 because the size of player is 100*100
		xMin = 50; 
		yMax = Screen.height - 50;
		yMin = 50;
	}
}