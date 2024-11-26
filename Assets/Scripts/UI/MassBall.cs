using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MassBall : MonoBehaviour
{
    public TMP_InputField ValueMass;
    public Rigidbody CannonBallPrefabRigidbody;

    public void UpdateCannonBallMass(float Value)
    {
        CannonBallPrefabRigidbody.mass = Value;

        if (ValueMass != null)
        {
            ValueMass.text = Value.ToString("F2");
        }
    }
}