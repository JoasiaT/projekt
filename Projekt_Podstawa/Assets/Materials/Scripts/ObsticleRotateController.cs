using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleRotateController : MonoBehaviour
{

   //Update is called once per frame;
   void Update()
    {
     transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z +50 * Time.deltaTime);
    }
}
