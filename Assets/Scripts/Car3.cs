using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car3 : MonoBehaviour
{
	public float num = 0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
		{
			num++;
		}
    }
}
