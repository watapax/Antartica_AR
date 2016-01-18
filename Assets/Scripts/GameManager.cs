using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	public static GameManager instance;
	public GameObject ar, inicio;

	void Awake()
	{
		instance = this;
	
		inicio.SetActive(true);

		// al incio apago la AR
		ar.SetActive(false);

	}

	public void Activar()
	{
		ar.SetActive(true);
		inicio.SetActive(false);
	}

	void ActivarAr()
	{

	}

}
