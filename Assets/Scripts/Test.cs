using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Awake()
	{
		float metros = 0;
		float palos = 0;
		for(int i = 0; i < 50; i++)
		{
			metros += i*7;
		}

		metros *= 4;
		metros /= 100;
		metros/= 2.4f;

		print (metros / 2);
	}

}
