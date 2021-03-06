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
	public class GE_Manual_Shooter_Cart : GameElement
	{
		//public DragShooter drag_shooter_prefab;
		public GameObject projectile_prefab;
		//public Transform drag_shooter_spawn_position;

		//public string target_tag;
		public float power;
		public int damage;

		public float reload_time;
		public int health;

		BehaviourManualShooter shooter_behaviour;

		protected override void Awake(){

			base.Awake ();

			//name_string = "Manual Shooter Cart";

			if (projectile_prefab != null) {

				//beh_shooter = new BehaviourShooter (this, projectile, damage, range, frequency, target_tag);
				shooter_behaviour = new BehaviourManualShooter(this,projectile_prefab,power,damage);
				Behaviours.Add (shooter_behaviour);

				Behaviours.Add (new BehaviourHealthPoints (this,health));

			}

		}

		public void ShootManual(Vector2 delta_position){

			shooter_behaviour.Shoot (delta_position);

		}

//		protected override void Start(){
//
//			shooter_behaviour.SpawnObject ();
//
//			shooter_behaviour.SupportObject.SendMessage ("SetProjectile", projectile_prefab);
//
//		}
		
	}
}

