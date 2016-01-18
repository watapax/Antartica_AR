using UnityEngine;

using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Capa{
	public string nombreCapa;
	public GameObject objeto;

}

public class LayerManager : MonoBehaviour {

	public Capa[] capas;
	public Image subir, bajar;
	public Animator menuAnim;
	public Text tituloCapa;
	public Animator animCamaraAR;
	public GameObject datosRelieve;

	bool menuActivo;


	void Awake()
	{
		datosRelieve.SetActive(false);
		subir.enabled = false;
		for(int i = 0; i < capas.Length; i++)
		{
			capas[i].objeto.SetActive(false);
		}

		capas[0].objeto.SetActive(true);
		tituloCapa.text = capas[0].nombreCapa;
	}

	public void ToggleMenu()
	{
		if(!menuActivo)
		{
			menuAnim.SetTrigger("bajar");
			animCamaraAR.SetTrigger("blur");
			subir.enabled = true;
			bajar.enabled = false;
			menuActivo = true;

		}
			
		else
		{
			menuAnim.SetTrigger("subir");
			animCamaraAR.SetTrigger("sinBlur");
			subir.enabled = false;
			bajar.enabled = true;
			menuActivo = false;
		}
	}

	public void ActivarCapa(int capaActiva)
	{
		for(int i = 0; i < capas.Length; i++)
		{
			if(i == capaActiva)
				capas[i].objeto.SetActive(true);
			else
				capas[i].objeto.SetActive(false);
		}
		tituloCapa.text = capas[capaActiva].nombreCapa;
		bool activarDatosRelieve = capas[3].objeto.activeInHierarchy;
		datosRelieve.SetActive(activarDatosRelieve);
	}








}
