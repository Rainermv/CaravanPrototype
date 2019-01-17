//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//using System;
using UnityEngine;

namespace Caravan
{
	public class Spawner : MonoBehaviour
	{
		public Trajectory[] trajectories;

		public Vector3 Position { get{return this.transform.position;}}

		public void SpawnEnemy(GameElement enemy_template, GameElement enemy_target){

			if (trajectories.Length == 0)
				return;

			Trajectory enemy_trajectory = trajectories [Random.Range (0, trajectories.Length)];

			GameObject enemy = Instantiate (enemy_template.gameObject, this.transform.position, Quaternion.identity) as GameObject;

			enemy.GetComponent<GE_Enemy_Basic> ().SetParameters (enemy_trajectory, enemy_target.gameObject);

		}
	}
}

