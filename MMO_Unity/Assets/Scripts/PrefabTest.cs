using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject tank;
    void Start()
    {
        tank = Managers.Resource.Instantiate("Tank");
        //Destroy(tank, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
