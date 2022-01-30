using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private int _HorsePower;
    public int HorsePower
    {
        get
        {
            return _HorsePower;
        }
        set
        {
            if (value <= 0)
                Debug.Log("Horsepower should be an number greather than 0");

            _HorsePower = value;
        }
    }

    protected void Accelerate()
    {
        var force = 10 * HorsePower;
    }
}
