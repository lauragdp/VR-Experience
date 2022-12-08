using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Teletransportation : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }

}
