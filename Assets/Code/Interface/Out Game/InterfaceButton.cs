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

using SoundSystem;

namespace Interface
{
	public class InterfaceButton : MonoBehaviour
	{
		public AudioClip Audio_OnClick;

		SoundController sound_controller_ref;

		protected virtual void Awake(){

			sound_controller_ref = SoundController.GetInstance ();

		}

		public void PressButton(){

			SoundController.GetInstance ().PlayBGS (Audio_OnClick);

		}
	}
}

