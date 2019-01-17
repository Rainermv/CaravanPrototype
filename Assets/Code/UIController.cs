using UnityEngine;
using System.Collections;

namespace Caravan{

	public class UIController : MonoBehaviour {

		public bool pause = false;

		float scale = 1.0f;

		// Use this for initialization
		void Start () {
			pause = false;
		}
		
		// Update is called once per frame
		void Update () {

			UpdateGameScale ();

		}

		void UpdateGameScale(){

			if (pause) 
				scale = 0.0f;
			else
				scale = 1.0f;
			
			Time.timeScale = scale;
		}

		public void TogglePause(){

			pause = !pause;
		}
	}
}
