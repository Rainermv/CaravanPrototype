


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine.UI;
using UnityEngine;


namespace Caravan
{
	public class DragShooter : MonoBehaviour
	{
		//public GameObject projectile_prefab;
		public GameElement manual_shooter_element;

		//GameObject _bow;

		//private float 	power;
		//private int 	damage;
		private Vector3 starting_position;
		private Vector3 pull_position;
		private Vector3 delta_pull;
		private bool 	pulling = false;

		void Awake(){

			//_bow = bow;
			starting_position = transform.position;
		}


		public void OnMouseDown(){
			//public void OnMouseDown(){
			Debug.Log ("click");
			pulling = true;
		}

		public void Update(){

			if (pulling) {

				Vector2 mouse_pos = Input.mousePosition;
				pull_position = Camera.main.ScreenToWorldPoint(new Vector3 (mouse_pos.x, mouse_pos.y, 10));

				delta_pull = starting_position - pull_position;;

				//transform.position = new Vector3(pull_position.x, pull_position.y, starting_position.z);

				UpdateRotation();
			}
		}

		void UpdateRotation(){

			Vector3 reverse_delta = pull_position - starting_position;
			float angle = Mathf.Atan2(reverse_delta.y, reverse_delta.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		}

		public void OnMouseUp(){

			if (pulling == true) {
			
				pulling = false;

				transform.position = starting_position;

				manual_shooter_element.SendMessage ("ShootManual", (Vector2)delta_pull);;
			}

						
		}

//		void Shoot(){
//
//			//Vector2 dir = position - (Vector2)_parent.transform.position;
//			Vector2 Force = (starting_position - (Vector3)pull_position) * 100f;
//
//			GameObject projectile = Instantiate (projectile_prefab, starting_position, Quaternion.identity) as GameObject;
//
//			//Debug.Log ("shooting using force " + Force);
//			projectile.GetComponent<Rigidbody2D> ().AddForce (Force);
//
//		}

//		public void SetProjectile(GameObject prefab){
//
//			projectile_prefab = prefab;
//
//		}
	}
}

