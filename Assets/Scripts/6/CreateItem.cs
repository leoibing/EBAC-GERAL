using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
	public GameObject prefab;
	public Transform shootPoint;
	public Vector3 forceDirection;

	public PoolManager poolManager;

	private void Update()
    {
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			SpawnObject();
		}
	}

	private void SpawnObject()
	{
		var obj = poolManager.GetPooledObject();
		//var obj = Instantiate(prefab);

		if (obj != null)
		{
			obj.SetActive(true);
			obj.GetComponent<Projectile>().StartProjectile();
			obj.transform.SetParent(null);
			obj.transform.position = shootPoint.transform.position;
			obj.transform.rotation = shootPoint.transform.rotation;
		}

		//obj.GetComponent<Rigidbody>().AddForce(forceDirection);
	}
}
