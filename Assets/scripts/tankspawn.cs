using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class tankspawn : MonoBehaviour
{
    public GameObject tankPrefab;
    public int HowManyAreThere = 0;
    public GameObject spawnedTank;
    public firstScript tankscript;
    public SpriteRenderer tanksr;
    public List <GameObject> tanks;
    public Transform barrel;
    public GameObject Duckie;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {



            Vector2 spawnPos = Random.insideUnitCircle * 3;
            //Quaternion.identity means 0,0,0 in math speak ||| this equates to the euler angle
            spawnedTank = Instantiate(tankPrefab, spawnPos, Quaternion.identity);

            //should be used
            //Instantiate(tankPrefab,transform.position,transform.rotation);

            tankscript = spawnedTank.GetComponent<firstScript>(); 
            tanksr = spawnedTank.GetComponent <SpriteRenderer>();

            HowManyAreThere++;
            tankscript.speed = HowManyAreThere;
            tankscript.body.color = Random.ColorHSV();

            tanks.Add(spawnedTank);

            Instantiate(Duckie, Random.insideUnitCircle * 3, Quaternion.identity);


            for (int i = 0; i < tanks.Count; i++)
            {
                firstScript ts = tanks[i].GetComponent<firstScript>();
                ts.speed = HowManyAreThere;
            }
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //appears as child of transform and set at 0,0
            // Instantiate(tankPrefab, transform);

            tanks.Remove(spawnedTank);
            Destroy(spawnedTank);
        }

        for(int i = tanks.Count - 1; i >= 0;  i--)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
            if(distance < 0.5f)
            {
                Debug.Log("explode" + i);
                GameObject tank = tanks[i];

                //either works
                tanks.Remove(tank);
                //tanks.RemoveAt(1);
                Destroy(tank);
            }
        }

    }
}
