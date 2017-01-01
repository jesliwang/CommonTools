using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AfterImageComponent))]
public class TestAfterImageCompent : MonoBehaviour {

	protected AfterImageComponent afterImage;

	protected Rigidbody physic;

	// Use this for initialization
	void Awake () {
		afterImage = GetComponent<AfterImageComponent>();
		physic = GetComponent<Rigidbody>();

		afterImage.Play(10.0f, 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		physic.AddForce(new Vector3(1,0), ForceMode.Force);
	}
}
