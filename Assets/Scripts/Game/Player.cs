using UnityEngine;
using QFramework;
using UnityEngine.Tilemaps;

namespace ProjectIndieFarm
{
	public partial class Player : ViewController
	{

		public Grid grid;

		public Tilemap tileMap;
		void Start()
		{
			// Code Here
		}


        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
			{
                // get tilemap according to the X Y value
                var cellPosition = grid.WorldToCell(transform.position);


                //eliminate the X Y number 
                tileMap.SetTile(cellPosition, null);

            }
        }
    }
}
