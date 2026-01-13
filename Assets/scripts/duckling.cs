using UnityEngine;
using UnityEngine.UIElements;

public class duckling : MonoBehaviour
{
    public AnimationCurve curve;
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;

        }
        transform.position = new Vector3(0, curve.Evaluate(t), 0);
    }
}