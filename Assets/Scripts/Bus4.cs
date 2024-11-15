using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Animais
{
	Dog,
	Cat,
	Fish
}

public class Bus4 : MonoBehaviour
{
	public KeyCode keycode1 = KeyCode.A;
	public KeyCode keycode2 = KeyCode.S;
	public KeyCode keycode3 = KeyCode.D;

	void Update()
    {
		CheckKeys();
	}

	private void CheckSwitchCase(Animais a)
	{
		switch (a)
		{
			case Animais.Dog:
				Debug.Log("Dog");
				break;
			case Animais.Cat:
				Debug.Log("Cat");
				break;
			case Animais.Fish:
				Debug.Log("Fish");
				break;
			default:
				Debug.Log("default");
				break;
		}
	}

	private void CheckKeys()
	{
		if (Input.GetKeyDown(keycode1))
		{
			CheckSwitchCase(Animais.Dog);
		}
		else if (Input.GetKeyDown(keycode2))
		{
			CheckSwitchCase(Animais.Cat);
		}
		else if (Input.GetKeyDown(keycode3))
		{
			CheckSwitchCase(Animais.Fish);
		}
	}
}
