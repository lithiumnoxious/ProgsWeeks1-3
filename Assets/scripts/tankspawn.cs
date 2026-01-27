using UnityEngine;
using UnityEngine.InputSystem;

public class tankspawn : MonoBehaviour
{
    public GameObject tankPrefab;
    public int HowManyAreThere = 0;
    public GameObject spawnedTank;
    public firstScript tankscript;
    public SpriteRenderer tanksr;

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
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //appears as child of transform and set at 0,0
            Instantiate(tankPrefab, transform);
        }
    }
}
