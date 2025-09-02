using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VRWalk : MonoBehaviour
{
    //Atributo
    public Transform vrCamera;

    //Variables de clase
    public float angle = 30.0f;
    public float speed = 3.0f;
    public bool move;

    public CharacterController cc;

    void start()
    {
        cc = this.GetComponent<CharacterController>();

    }

    void Update()
    {
        if (vrCamera.eulerAngles.x >= angle && vrCamera.eulerAngles.x < 60.0f)
        {
            move = true;
        }
        else
        {
            move = false;
        }

        if (move)
        {
            Vector3 direction = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(direction * speed);
        }

    }
}
