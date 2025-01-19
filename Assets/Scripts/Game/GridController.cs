using UnityEngine;
using QFramework;
using UnityEngine.Tilemaps;

namespace ProjectIndieFarm
{
	public partial class GridController : ViewController
	{
		private EasyGrid<bool> mShowGrid = new EasyGrid<bool>(10,10);

		public TileBase pen;


		void Start()
		{
			mShowGrid[0, 0] = true;
			mShowGrid[2, 0] = true;
			// Code Here
		}
	}
}
