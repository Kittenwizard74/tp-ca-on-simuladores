using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WindDrag : MonoBehaviour
{
    public TMP_InputField ValueDrag;
    public Rigidbody CannonBallPrefabRigidbody;

    public void UpdateCannonBallMass(float Value)
    {
        CannonBallPrefabRigidbody.drag = Value;

        if (ValueDrag != null)
        {
            ValueDrag.text = Value.ToString("F2");
        }
    }
}