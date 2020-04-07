using UnityEngine;
using System.Collections;

public class FlickeringLight_Torch : MonoBehaviour {

	public Light fuseLight;
	private float fuseLightIntensity = 0.4f;

	void Start (){

	}

	void Update (){

		fuseLightIntensity = (Random.Range (0.5f, 1.5f));
		fuseLight.intensity = fuseLightIntensity;

	}
}