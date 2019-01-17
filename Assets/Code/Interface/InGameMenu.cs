using UnityEngine;
using System.Collections;

namespace Caravan{

	public enum InGameMenuState{
		Offscreen,
		Onscreen
	}

	public class InGameMenu : MonoBehaviour {

		InGameMenuState state = InGameMenuState.Offscreen;

		private Vector2 off_screen;
		public Transform on_screen;

		public float speed = 0.1f;

		// Use this for initialization
		void Start () {

			off_screen = transform.position;

		}

		// Update is called once per frame
		void Update () {

		}

		public void ChangeState(){

			StartCoroutine (CoroutineMove ());

		}

		IEnumerator CoroutineMove(){

			Vector2 starting_position = Vector2.zero;
			Vector2 target_position = Vector2.zero;
		
			float lerp = 0.0f;

			if (state == InGameMenuState.Offscreen) {
				starting_position = off_screen;
				target_position = on_screen.position;

				state = InGameMenuState.Onscreen;
			} 

			else if (state == InGameMenuState.Onscreen) {
				starting_position = on_screen.position;
				target_position = off_screen;

				state = InGameMenuState.Offscreen;
			}

			while (lerp <= 1f) {

				lerp += speed;
				transform.position = Vector2.Lerp(starting_position, target_position, lerp);

				yield return 0;

			}

			transform.position = target_position;



		}
	}
}
