using System.Collections;
using UnityEngine;

public class NewObjectController1 : MonoBehaviour
{
    bool rotate = true;

    public void Start()
    {
        FixedUpdate();
    }

    public void OnPointerClick()
    {
        rotate = !rotate;
    }

    public void FixedUpdate()
    {
        if (rotate)
        {
            Vector3 position = this.GetComponent<Renderer>().bounds.center;
            this.transform.RotateAround(position, Vector3.up, 30f * Time.deltaTime);
        }
        
    }
}