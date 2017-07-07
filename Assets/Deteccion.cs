using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion : MonoBehaviour {
	private GameObject camera_01;
	private float velocityCamera=1;
	private GameObject objSpawn;
	private Transform transformSpawn;
	// Use this for initialization
	//public SpawnObjetos scriptObj; 
	private Transform cameraTransform;
	private Rigidbody rb;
	private bool active=false;
	private float height;
	void Start () {

		camera_01=GameObject.FindGameObjectWithTag("camara");
	//	rb
		objSpawn=GameObject.FindGameObjectWithTag("jugador");
		transformSpawn=objSpawn.GetComponent<Transform>();
		cameraTransform=camera_01.GetComponent<Transform>();
		height=this.transform.localScale.y;
		print("ancho "+height);
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision c){
		if(c.collider.tag=="enemigo"&&active==false){
			cameraTransform.Translate(Vector3.up*velocityCamera);
			//transformSpawn.transform.position=new Vector3(transform.position.x,transform.position.y+height,transform.position.z);
			transformSpawn.Translate(Vector3.up*velocityCamera);

			print("contacto caja");
			active=true;
		}else{
			if(c.collider.tag=="piso"&&SpawnObjetos.cantidadCajas!=1){
				print("perdiste");
			//	SpawnObjetos.gameOver=true;
			}
		}

	}
}
