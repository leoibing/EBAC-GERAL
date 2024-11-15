using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonIncreaseDecrease : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Animations")]
    public Animator animator;

    public bool Button = false;
    public string ButtonBoolName;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button = true;
        animator.SetBool(ButtonBoolName, Button);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button = false;
        animator.SetBool(ButtonBoolName, Button);
    }
}
