using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoallisionDetection : MonoBehaviour {
	public InputMovement playerMovement;

		void OnCollisionStay(Collision col){
		if (col.gameObject.name.Equals ("Land") || 
			col.gameObject.tag.Equals ("Land"))
			//Debug.log ("abcd");
		{
			playerMovement.canJump = true;
			}
			
		}

		void OnCollisionExit(Collision col){
		if (col.gameObject.name.Equals ("Exit") ||
			col.gameObject.tag.Equals ("Exit"))
		{
			playerMovement.canJump = false;
			}
		}

		void OnTriggerEnter(Collider col){
		}

		void OnTriggerStay(Collider col){
		}

		void OnTriggerExit(Collider col){
		}
	}
