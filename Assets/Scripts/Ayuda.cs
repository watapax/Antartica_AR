using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class Tips{

	public string textoAyuda;
	public Sprite spriteImagenAyuda;
	public Image puntitoAyuda;
}


public class Ayuda : MonoBehaviour {


	public Text textoAyuda;
	public Image imagenAyuda;
	public Tips[] tips;
	int index = 0;
	Color colorPuntoDestacado = Color.magenta;

	void Start()
	{
		tips[0].puntitoAyuda.color = colorPuntoDestacado;
		textoAyuda.text = tips[0].textoAyuda;
		imagenAyuda.sprite = tips[0].spriteImagenAyuda;


	}

	public void CambiarAyuda()
	{

		tips[index].puntitoAyuda.color = Color.white;

		index++;
		if(index == tips.Length)
			index = 0;

		textoAyuda.text = tips[index].textoAyuda;
		imagenAyuda.sprite = tips[index].spriteImagenAyuda;
		imagenAyuda.SetNativeSize();
		tips[index].puntitoAyuda.color = colorPuntoDestacado;
	}

	public void AbrirDireccion()
	{
		Application.OpenURL("http://www.inach.cl/antartica-ra");
	}

}
