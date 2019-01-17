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
	public class GE_Auto_Shooter_Cart : GameElement
	{
		public GameObject projectile;


		//public GameObject upgrade;
		//public int upgrade_cost;

		public string target_tag;
		public float range;
		public float frequency;
		public int damage;

		BehaviourShooter beh_shooter;

		public int health;

		protected override void Awake(){

			base.Awake ();

			name_string = "Shooter Cart";

			if (projectile != null) {
				beh_shooter = new BehaviourShooter (this, projectile, damage, range, frequency, target_tag);
				Behaviours.Add (beh_shooter);
				Behaviours.Add (new BehaviourHealthPoints (this,health));

				//Behaviours.Add (new BehaviourUpgradable(this, upgrade, upgrade_cost));
			}


		}

		public override float GetRange(){

			return range;

		}

		
	}
}

