using System.Collections;
using System.Collections.Generic;
using Unity.Sentis;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class RightArmUpRigging : MonoBehaviour
{

	private Rig rig;
	float targetWeight;

    // Start is called before the first frame update
    void Start()
    {
	    rig = GetComponent<Rig>();

    }

    // Update is called once per frame
    void Update()
    {
		rig.weight = Mathf.Lerp(rig.weight, targetWeight, Time.deltaTime * 10f);

		if (Input.GetKey(KeyCode.E))
		{
			targetWeight = 1f;
		}

		if (Input.GetKey(KeyCode.Q))
		{
			targetWeight = 0f;
		}
    }
}
