using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cannon : MonoBehaviour
{
    #region variables
    [Header("shooting")]
    public GameObject CannonBallFrefab;
    public Transform FirePoint;
    public float InitialForceMagnitude = 10f;

    bool CanFire = true;
    public int CoolDownTime = 2;

    [Header("variables")]
    public TMP_InputField coordenadasY;
    public TMP_InputField coordenadasX;
    #endregion
    #region base methods
    void Update()
    {
        if (Input.GetAxis("Jump") > 0.0f && CanFire)
        {
            StartCoroutine(FireWithCoolDown());
        }
    }

    IEnumerator FireWithCoolDown()
    {
        CanFire = false;
        Fire();
        yield return new WaitForSeconds(CoolDownTime);
        CanFire = true;
    }
    #endregion
    #region custom methods
    void Fire()
    {
        GameObject Ball = Instantiate(CannonBallFrefab, FirePoint.position,FirePoint.rotation);

        Rigidbody RB = Ball.GetComponent<Rigidbody>();
        Vector3 InitialForce = transform.right * InitialForceMagnitude;
        RB.AddForce(InitialForce, ForceMode.Impulse);
    }

    public void SliderFunctionY(float Value)
    {
        transform.rotation = Quaternion.Euler(0,0 ,Value);

        if (coordenadasY != null)
        {
            coordenadasY.text = Value.ToString("F2");
        }
    }

    public void SliderFunctionX(float Value)
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, Value, transform.rotation.eulerAngles.z);

        if (coordenadasX != null)
        {
            coordenadasX.text = Value.ToString("F2");
        }
    }
    #endregion
}