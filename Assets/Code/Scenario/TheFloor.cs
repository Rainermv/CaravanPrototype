using UnityEngine;
using System.Collections;

namespace Caravan{
	public class TheFloor : MonoBehaviour {

		public float speed;

		void OnCollisionEnter2D(Collision2D coll){

			coll.rigidbody.fixedAngle = true;
		}

		void OnCollisionStay2D(Collision2D coll){

			//coll.rigidbody.velocity = new Vector2(-speed,0);


		}

	}
}