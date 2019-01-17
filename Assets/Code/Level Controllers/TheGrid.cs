using UnityEngine;
using System.Collections;

namespace Interface{

	public class TheGrid : MonoBehaviour {

		private static TheGrid instance;

		public int GRID_HEIGHT;
		public int GRID_WIDTH;
		public float CELL_SIZE;

		public GameObject Debug_Cell;
		public GameObject Debug_Point;

		float x_start;
		float y_start;

		float width;
		float height;

		void Awake(){

			TheGrid.instance = this;

		}

		// Use this for initialization
		void Start () {

			width 	= GRID_WIDTH * CELL_SIZE;
			height  = GRID_HEIGHT * CELL_SIZE;

			x_start = transform.position.x - width / 2;
			y_start = transform.position.y - height / 2;

		}

		void DebugDrawGrid(){

			if (Debug_Cell == null)
				return;

			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++){

					Vector3 position = new Vector3(x * GRID_WIDTH + x_start, 
					                               y * GRID_HEIGHT + y_start, 
					                               transform.position.z);

					GameObject cell = (GameObject) 
						Instantiate(Debug_Cell, position, Quaternion.identity);

				}

			}

		}

//		public static Vector2? GetGridPosition(Vector2 world_position){
//
//			if (instance.IsInsideBorders(world_position)){
//
//				//float x = 
//
//			}
//
//			return null;
//
//
//		}
//
//		// y go down
//		public bool IsInsideBorders(Vector2 position){
//
//			return (position.x > TOP_LEFT.position.x &&
//			        position.x < BOTTON_RIGHT.position.x &&
//			        position.y > BOTTON_RIGHT.position.y &&
//			        position.y < TOP_LEFT.position.y);
//
//		}
		
		// Update is called once per frame
		void Update () {
		
		}

	}
}
