using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sunsAI : MonoBehaviour
{


    public Transform Player;
    int MoveSpeed = 10;
   



    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(Player.position, this.transform.position) < 20)
        {

            Vector3 direction = Player.position - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                   Quaternion.LookRotation(direction), 0.1f);

            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.09f);
            }
          



        }
    }
}