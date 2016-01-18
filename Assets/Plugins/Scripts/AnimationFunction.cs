using UnityEngine;
using System.Collections;

public class AnimationFunction : MonoBehaviour {


	Animator anim;
	public Animator otroAnim;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	public void ReproducirOtroAnim(string trigger)
	{
		otroAnim.SetTrigger(trigger);
	}

}
