using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
	public EnemyData enemyData;

	private int _life;

	public KeyCode keycode1 = KeyCode.A;

	public void Awake()
    {
		_life = enemyData.startLife;
    }

    public void Update()
    {
		Attack();
	}

	public virtual void Attack()
	{
		if (Input.GetKeyDown(keycode1))
		{
			Damage(1);
		}
	}

	public void Damage(int f)
	{
		_life -= f;
		if (_life <= 0) Kill();
	}

	public void Kill()
	{
		Destroy(gameObject);
	}
}
