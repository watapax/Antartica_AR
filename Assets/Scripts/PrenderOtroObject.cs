using UnityEngine;
using System.Collections;

public class PrenderOtroObject : MonoBehaviour {

	public GameObject otroObject;

	void Awake()
	{
		otroObject.SetActive(false);
	}

	public void PrenderObjeto()
	{
		otroObject.SetActive(true);
	}

}
