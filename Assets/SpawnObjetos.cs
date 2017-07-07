using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour {
	public List<GameObject> obj=new List<GameObject>();


	public static bool gameOver=false;
	public static int cantidadCajas=0;
	private int index;
	void Start () {
		index=0;
	}
	
	// Update is called once per frame
	void Update () {
		//tiempo+=Time.deltaTime;

		//print("cajas "+);
		if(gameOver==false){
		if(Input.GetKeyDown(KeyCode.Mouse0)){
				if(index>=3){
					print("limite indice "+index);
					index=0;
				}
			cantidadCajas+=1;
			//print("cantidad cajas "+cantidadCajas);
				print("pos z "+transform.position.z);
				Instantiate(obj[index],transform.position,transform.rotation);
			index++;
		}
		}else{

		}
			

	}
}
