using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public float timeToReset = 5f;
	public Vector3 dir;

	private Rigidbody rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
    {
        transform.Translate(dir * Time.deltaTime);
    }

	public void StartProjectile()
	{
		Invoke(nameof(FinishUsage), timeToReset);
	}

	private void FinishUsage()
	{
		if (rb != null)
		{
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		}

		gameObject.SetActive(false);
	}
}
