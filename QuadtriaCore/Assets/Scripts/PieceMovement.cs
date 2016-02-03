using UnityEngine;
using System.Collections;

public class PieceMovement : MonoBehaviour {

	public Material[] materials;

	public bool itemSelected = false;
	private Rigidbody rb;
	private CapsuleCollider cc;
	private GameObject sphere;
	Vector3 newPosition;
	private Color originalColor;
	public GameManager _GameManager;


	void Start()
	{
		rb = GetComponent<Rigidbody>();
		cc = GetComponent<CapsuleCollider>();
		newPosition = transform.position;
		originalColor = GetComponent<Renderer> ().materials [0].color;
		_GameManager = GetComponent<GameManager> ();

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			OnRightClick();
		}
		if (Input.GetMouseButtonDown(0))
		{
			if (itemSelected == true)
			{
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					if (Physics.Raycast(ray, out hit))
					{
						if (hit.collider.tag == "circle")
						{
							newPosition = hit.point;
							transform.position = newPosition;
							GetComponent<Renderer> ().materials [0].color = originalColor;
							itemSelected = false;
						}
					}
				}
			}
		}

		_GameManager.WinCondition (_GameManager.m_QuadrantD, _GameManager.m_Player1Pieces);

	}
	void OnRightClick()
	{
		if (itemSelected == true)
		{
			GetComponent<Renderer> ().materials [0].color = originalColor;
			
			itemSelected = false;
		}

	}

	void OnMouseOver()
	{
		if (itemSelected == false)
		{
			if (Input.GetMouseButtonDown(0))
			{
				GetComponent<Renderer>().materials[0].color = Color.yellow;
				itemSelected = true;
			}

		}
		else if (itemSelected == true)
		{

		}

	}
}
