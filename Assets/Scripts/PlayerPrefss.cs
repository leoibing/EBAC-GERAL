using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefss : MonoBehaviour
{
	public float position;

    void Start()
    {
		position = PlayerPrefs.GetFloat("POSICAO", 1);

		position++;

		PlayerPrefs.SetFloat("POSICAO", position);
	}
}
