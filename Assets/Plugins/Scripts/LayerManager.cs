using UnityEngine;

using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Capa{
	public string nombreCapa;
	public GameObject objeto;
	public string textoInfo;
	public Sprite iconoInfo;
	public string fuenteInfo;
}



public class LayerManager : MonoBehaviour {

	public Capa[] capas;
	public Image subir, bajar;
	public Animator menuAnim;
	public Text tituloCapa;
	public Animator animCamaraAR;
	public GameObject datosRelieve;
	public Text textoInfo;
	public Image icoInfo;
	public Text fuenteInfo;
	public Button info;
	public Button menu;
	public GameObject opcionesCapas;



	bool menuActivo;

	public void CargarUrl(string url)
	{
		Application.OpenURL(url);
	}

	void Start()
	{
		datosRelieve.SetActive(false);

		subir.enabled = false;
		for(int i = 0; i < capas.Length; i++)
		{
			capas[i].objeto.SetActive(false);
		}

		capas[0].objeto.SetActive(true);
		tituloCapa.text = capas[0].nombreCapa;
		LlenarInformacion();
		textoInfo.text = capas[0].textoInfo;
		fuenteInfo.text = capas[0].fuenteInfo;
		icoInfo.sprite = capas[0].iconoInfo;
		opcionesCapas.SetActive(false);
	}




	public void LlenarInformacion()
	{
		for(int i = 0; i < capas.Length; i++)
		{
			//capas[i].textoInfo = "Gracias a la claridad de sus cielos y a los bajísimos niveles de contaminación lumínica, Chile se ha convertido en la capital mundial para la observación astronómica, concentrando cerca del 60% de la exploración cósmica a nivel planetario."+"\n\n"+"Chile Mobile Observatory ofrece, de manera libre y gratuita, las mejores imágenes del Universo captadas desde Chile por los más modernos observatorios construidos por el hombre, como ALMA (Atacama Large Millimeter/submillimeter Array), VLT (Very Large Telescope), o el Centro de Astrofísica y Tecnologías Afines (CATA).";
			//capas[i].fuenteInfo = "FUENTES:"+"\n"+"COMNAP-MAP 2009"+"\n"+"INACH-Departamento ECA"+"\n"+"MINREL-DIFROL";
		}

	}

	public void ToggleMenu()
	{
		if(!menuActivo)
		{
			opcionesCapas.SetActive(true);
			info.enabled = false;
			menuAnim.SetTrigger("bajar");
			animCamaraAR.SetTrigger("blur");
			subir.enabled = true;
			bajar.enabled = false;
			menuActivo = true;
		}
			
		else
		{
			info.enabled = true;
			menuAnim.SetTrigger("subir");
			animCamaraAR.SetTrigger("sinBlur");
			subir.enabled = false;
			bajar.enabled = true;
			menuActivo = false;
		}
	}

	public void MostrarAyuda()
	{
		info.enabled = true;
		menuAnim.SetTrigger("subir");
		subir.enabled = false;
		bajar.enabled = true;
		menuActivo = false;
		menu.enabled = false;
		info.enabled = false;
	}

	public void OcultarAyuda()
	{
		animCamaraAR.SetTrigger("sinBlur");
		menu.enabled = true;
		info.enabled = true;
	}

	public void MostrarInfo()
	{
		animCamaraAR.SetTrigger("blur");
		menu.enabled = false;
		info.enabled = false;
	}

	public void OcultarInfo()
	{
		animCamaraAR.SetTrigger("sinBlur");
		menu.enabled = true;
		info.enabled = true;
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
		textoInfo.text = capas[capaActiva].textoInfo;
		fuenteInfo.text = capas[capaActiva].fuenteInfo;
		icoInfo.sprite = capas[capaActiva].iconoInfo;
		bool activarDatosRelieve = capas[5].objeto.activeInHierarchy;
		datosRelieve.SetActive(activarDatosRelieve);


	}








}
