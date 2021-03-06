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
using UnityEngine;
using UnityEngine.UI;

namespace Interface
{

	public class InterfaceButtonToggle : InterfaceButton
	{
		public ToggleType option;

		private Toggle toggle_ref;

		protected override void Awake(){
			base.Awake ();

			toggle_ref = GetComponent<Toggle> ();

		}

		void Start(){

			bool is_on = false;

			switch (option) {
				
			case Interface.ToggleType.Music:
				is_on = Caravan.MainController.instance.Music;
				break;
				
			case  Interface.ToggleType.Sound:
				is_on = Caravan.MainController.instance.Sound;
				break;
			}

			toggle_ref.isOn = is_on;
		}

		public void UpdateOption(){

			Caravan.MainController.instance.SwitchOption (toggle_ref.isOn, option);

			PressButton ();

		}

			                                            
	
	}
}
