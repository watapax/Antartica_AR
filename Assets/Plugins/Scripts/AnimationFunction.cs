using UnityEngine;
using System.Collections;

public class AnimationFunction : MonoBehaviour {


	Animator anim;
	public Animator otroAnim;
	int toggleTrigger;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	public void ReproducirOtroAnim(string trigger)
	{
		otroAnim.SetTrigger(trigger);
	}
	public void ToggleTrigger()
	{
		if(toggleTrigger == 0)
		{
			anim.SetTrigger("mostrar");
			toggleTrigger++;
		}
		else
		{
			anim.SetTrigger("ocultar");
			toggleTrigger = 0;
		}
	}


}
