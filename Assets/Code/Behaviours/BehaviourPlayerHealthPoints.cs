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


namespace Caravan
{
	public class BehaviourPlayerHealthPoints : GameElementBehaviour
	{

		GameController game_instance;

		public BehaviourPlayerHealthPoints (GameElement parent) : base(parent){

			game_instance = GameController.GetInstance ();

		}

		public override void GameElementDamage (int value){

			game_instance.HealthPoints -= value;

		}





	}
}
