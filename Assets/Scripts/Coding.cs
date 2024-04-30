using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    int doorCount;
    string colorOfCar;
    int id;
    string liscencePlate;
    int horsePower;
    bool isElectric;
    float maxSpeed;

    Car(int doorCount, string colorOfCar, int id, string liscencePlate, int horsePower, bool isElectric, float maxSpeed)
    {
        this.doorCount = doorCount;
        this.colorOfCar = colorOfCar;
        this.id = id;
        this.liscencePlate = liscencePlate;
        this.horsePower = horsePower;
        this.isElectric = isElectric;
        this.maxSpeed = maxSpeed;
    }

    string Drive()
    {
         return "Driving";
    }

    void StartEngine()
    {
        Debug.Log("Engine Starting");
    }

    void Honk()
    {
        Debug.Log("HONK");
    }

    // Start is called before the first frame update
    void Start()
    {
        Car bmw = new Car(5, "BLACK", 1, "SK 1919 BJ", 150, false, 210.5f);
        string toPrint = bmw.Drive();
        bmw.StartEngine();

        int iterator = 0;

        string[] printableStrings = { "TEST1", "TEST2", "TEST3" };
        List<string> printableListStrings = new List<string>();

        int l = printableListStrings.Count;
        int x = printableStrings.Length;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
