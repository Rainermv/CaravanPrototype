using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Caravan
{
	public class GameController : MonoBehaviour {

		public GameElement enemy;
		public GameElement enemy_target;

		public int Starting_HP;
		public int Starting_Resources;

		public float Spawn_Timer;

		public Vector2 Rotation_Treshold;

		private int _score = 0;
		private int _elapsed_time = 0;

		private int _resources;
		private int _health_points;

		public int Score {
			get {
				return _score;
			}
			set {
				_score = value;
			}
		}

		public int HealthPoints {
			get {
				return _health_points;
			}
			set {
				_health_points = value;
			}
		}

		public int ElapsedTime {
			get {
				return _elapsed_time;
			}
			set {
				_elapsed_time = value;
			}
		}

		public int Resources {
			get {
				return _resources;
			}
			set {
				_resources = value;
			}
		}

		Spawner[] game_spawners;
		List<GameElement> game_elements = new List<GameElement>();
		// Trajectory trajectories
		// GameElement game_elements

		// SINGLETON
		private static GameController instance;

		public static GameController GetInstance(){

			if (instance == null)
				instance = FindObjectOfType<GameController> ();

			return instance;
		}

		public Spawner[] GameSpawners {
			get {
				return game_spawners;
			}
			set {
				game_spawners = value;
			}
		}

		void Awake(){
			game_spawners = FindObjectsOfType<Spawner> ();
		}

		// Use this for initialization
		void Start () {


			_health_points = Starting_HP;
			_resources = Starting_Resources;

			StartCoroutine (CoroutineEnemySpawn ());
			StartCoroutine (CoroutineCountTime());


		}
		
		// Update is called once per frame
		void Update () {
		
		}

		IEnumerator CoroutineEnemySpawn(){

			float timer = Spawn_Timer;

			while (true) {
					SpawnEnemy();
		
				yield return new WaitForSeconds(timer);
			

			}

		}

		void SpawnEnemy(){

			if (game_spawners.Length == 0)
				return;

			// choose a spawner at random
			Spawner target_spawner = game_spawners [Random.Range (0, game_spawners.Length)];

			target_spawner.SpawnEnemy (enemy, enemy_target);
		}

		public bool SpendResource(int value){

			if (_resources >= value) {
				_resources -= value;
				return true;
			}

			return false;

		}

		IEnumerator CoroutineCountTime(){

			while (true) {
				yield return new WaitForSeconds(1f);

				_elapsed_time++;
			}

		}
	}
}
