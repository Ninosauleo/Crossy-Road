using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveDistance = 1;
	public float moveTime = 0.4f;
	public float colliderDistCheck = 1;
	public bool isIdle = true;
	public bool isDead = false;
	public bool ismoving = false;
	public bool isJumping = false;
	public bool jumpStart = false;
	public ParticleSystem particle = null;
	public GameObject chick = null;
	private Renderer renderer = null;
	private bool isVisible = false;

	void Start(){
	
	}

	void Update(){
		CanIdle ();
		CanMove ();

	}
		
	void CanIdle(){
		if(isIdle){
			if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) {
				CheckIfCanmove ();
			}
		}

	}

	void CheckIfCanmove(){
		//Raycast find if there is any collider in front of the player
		setMove();
	
	}

	void setMove(){
		Debug.Log ("Hit nothing. keep moving!");
		isIdle = false;
		ismoving = true;
		jumpStart = true;
	}

	void CanMove(){
		if (ismoving) {
			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				Moving (new Vector3 (transform.position.x, transform.position.y, transform.position.z + moveDistance));
				SetMoveForwardState ();
			} else if (Input.GetKeyUp (KeyCode.DownArrow)) {
				Moving (new Vector3 (transform.position.x, transform.position.y, transform.position.z - moveDistance));
			} else if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				Moving (new Vector3 (transform.position.x - moveDistance, transform.position.y, transform.position.z));
			} else if (Input.GetKeyUp (KeyCode.RightArrow)) {
				Moving (new Vector3 (transform.position.x + moveDistance, transform.position.y, transform.position.z + moveDistance));
			}
		}
	}
		
	void Moving(Vector3 pos){
		isIdle = false;
		ismoving = false;
		isJumping = true;
		jumpStart = false;
		LeanTween.move (this.gameObject, pos, moveTime).setOnComplete(MoveComplete);
	}

	void MoveComplete(){
		isJumping = false;
		isIdle = true;
	
	}

	void SetMoveForwardState(){
	
	}

	void IsVisible(){
	
	}

	void GotHit(){
	
	}
}
