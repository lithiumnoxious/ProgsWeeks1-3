using System.Security.Cryptography;
using UnityEngine;

public class Pupilspulse : MonoBehaviour
{
    public AnimationCurve pulse;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)s
        {
            time = 0;
        }
        transform.localScale = Vector3.one * pulse.Evaluate(time);
    }
}
