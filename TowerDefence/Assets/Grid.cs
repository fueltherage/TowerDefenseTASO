using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	// Use this for initialization
	Cell[,] cells;
	int gridWidth=10;
	int gridHeight=10;
	public GameObject cellObject;
	void Start () {
		GenerateGrid();	
	}

	
	// Update is called once per frame
	void Update () {
	
	}
	void GenerateGrid()
	{
		cells = new Cell[gridWidth, gridHeight];

		for(int i=0; i<gridWidth; i++)
		{
			for(int j=0; j<gridHeight;j++)
			{
				cells[i,j].x = i;
				cells[i,j].y = j;
				Instantiate(cellObject, new Vector3(i,j,0),Quaternion.identity);
				
			}
		}
		

	}
}
