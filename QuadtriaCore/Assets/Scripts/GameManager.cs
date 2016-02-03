using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour {






	///*[HideInInspector]*/public GameObject m_GameBoard;
	[HideInInspector] public GameObject[] m_QuadrantA;
	[HideInInspector] public GameObject[] m_QuadrantB;
	[HideInInspector] public GameObject[] m_QuadrantC;
	[HideInInspector] public GameObject[] m_QuadrantD;
	public GameObject m_Player1Signal;
	public GameObject m_Player2Signal;
	public GameObject[] m_Player1Pieces;
	public GameObject[] m_Player2Pieces;
	private GameObject m_SelectedPiece;
	public bool isSelected = false;
	private int m_PlayerTurn = 1;
	private Rigidbody rb;
	private SphereCollider sc;

	Vector3 newPosition;


	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		sc = GetComponent<SphereCollider>();
		newPosition = transform.position;
	}

	void Update ()
	{
		/*if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) 
			{
				if (isSelected == true) 
				{
					
					if (hit.collider.tag == "circle") 
						{ // and valid spot
							newPosition = hit.collider.transform.position;
							transform.position = newPosition;
							isSelected = false;
						}
				
						

						
						HomeQuadrantEmpty (m_QuadrantD, m_Player1Pieces, m_Player1Signal);
					
				}

				else if (hit.transform.tag == "player1Piece") 
				{
					isSelected = true;
					//GetComponentsOfChildren<Renderer> ().materials [0].color = Color.yellow;
				}


			}
		}*/
	}


	void MakeMove()
	{
		
	}

	void WinCondition(GameObject[] m_Quadrant, GameObject[] m_PlayerPieces)//who's pieces are being checked and what quadrant will be the parameters
	{
		int pieceIndex = 0;
		for (int i = 0; i < 5; i++) 
		{
			if (m_Quadrant [i].transform.position == m_PlayerPieces [i].transform.position) 
			{
				pieceIndex++;
			}
		}

		if (pieceIndex > 3) 
		{
			//4 or more pieces in quadrant, all possible configurations result in a triangle
			PlayerWon (m_PlayerPieces);
		}

		if (pieceIndex == 3) 
		{
			//three pieces, possible triange, have to check

		} 
		else 
		{
			//less than 3 pieces no possible triangles
			return;
		}

	}

	void PlayerWon(GameObject[] m_Winner)
	{
		Debug.Log ("Player won");
	}

	void HomeQuadrantEmpty(GameObject[] m_Quadrant, GameObject[]m_PlayerPieces, GameObject m_Signal)
	{
		int pieceIndex = 0;
		for (int i = 0; i < m_Quadrant.Length; i++) 
		{
			if (m_Quadrant [i].transform.position == m_PlayerPieces [i].transform.position) 
			{
				pieceIndex++;
			}
		}

		if (pieceIndex == 0) 
		{
			//set bool for home signal to true
			m_Signal.transform.position = new Vector3(5.34f,3f,-3.53f);
		}
	}
}
