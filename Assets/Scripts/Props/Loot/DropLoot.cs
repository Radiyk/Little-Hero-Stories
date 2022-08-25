using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropLoot : MonoBehaviour
{
   //[SerializeField]
	public   GameObject loot;
	
	public Transform shotPoint;
	


	  	public void ShotLoot()
	{
		
        Instantiate(loot, shotPoint.position, shotPoint.rotation);

	}

}
