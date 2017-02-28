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
		CanMove ();

	}
		
	void CanIdle(){
	
	}

	void CheckIfCanmove(){
	
	}

	void setMove(){
	
	}

	void CanMove(){
		if(Input.GetKeyDown (KeyCode.UpArrow)){
			Moving (new Vector3(transform.position.x, transform.position.y, transform.position.z + moveDistance));
		}
		else if(Input.GetKeyDown (KeyCode.DownArrow)){
			Moving (new Vector3(transform.position.x, transform.position.y, transform.position.z - moveDistance));
		}
		else if(Input.GetKeyDown (KeyCode.LeftArrow)){
			Moving (new Vector3(transform.position.x - moveDistance, transform.position.y, transform.position.z));
		}
		 else if(Input.GetKeyDown (KeyCode.RightArrow)){
			Moving (new Vector3(transform.position.x + moveDistance, transform.position.y, transform.position.z + moveDistance));
		}
	}
		
	void Moving(Vector3 pos){
		LeanTween.move (this.gameObject, pos, moveTime);
	}

	void MoveComplete(){
	
	}

	void SetMoveForwardState(){
	
	}

	void IsVisible(){
	
	}

	void GotHit(){
	
	}
}
