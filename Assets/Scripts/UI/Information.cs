using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Information : MonoBehaviour
{
    private float CollisionTime;
    private bool HasCollided = false;
    public TextMeshProUGUI CollisionText;

    private void Start()
    {
        CollisionText = GameObject.FindGameObjectWithTag("Text Information").GetComponent<TextMeshProUGUI>();
    }

    private void OnCollisionEnter(Collision Collision)
    {
        if (!HasCollided && Collision.gameObject.CompareTag("Plataform"))
        {
            CollisionTime = Time.time;

            if (CollisionText != null)
            {
                CollisionText.text = "Impacto al suelo a las " + CollisionTime.ToString("F2") + " segundos.";
            }

            HasCollided = true;
        }
    }
}
