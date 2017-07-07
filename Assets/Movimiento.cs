using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	// Use this for initialization
	private Transform transformObj;
	public float velocidad;
	private float tiempo;
	private int direccion=1;
	public float li;
	public float ls;
	void Start () {
		transformObj=GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		//tiempo+=Time.deltaTime;

		if(transform.position.x<ls){
			direccion=1;
		}
		if(transform.position.x>li){
			direccion=-1;
		}
			
		transformObj.transform.Translate(Vector3.right*Time.deltaTime*velocidad*direccion);
	}
}
