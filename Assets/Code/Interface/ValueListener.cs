using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Caravan{
	public class ValueListener : MonoBehaviour {

		public ListenerType type;

		Text text_reference;
		GameController game_controller;

		void Awake(){

			text_reference = GetComponent<Text> ();
			game_controller = GameController.GetInstance ();
		}

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void LateUpdate () {
			if (text_reference != null && game_controller != null) {
				text_reference.text = GetStringFromType();
			}

		}

		string GetStringFromType(){
			switch (type) {
			case ListenerType.Health: 
				return game_controller.HealthPoints.ToString();
			case ListenerType.Resources:
				return game_controller.Resources.ToString();
			case ListenerType.Score:
				return game_controller.Score.ToString();
			case ListenerType.Timer:
				return game_controller.ElapsedTime.ToString();
			}

			return "";
		}
	}
}