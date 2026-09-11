using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("rota", .01f, 0.1f);
    }

    public GameObject rays;

    float rot = 20;
    
    void rota()
    {
        if (rot == 360)
        {
            rot = 0f;
        }
        else
        {
            
            rot += Random.Range(0.01f, 0.1f);
        }
        rays.transform.Rotate(0.0f, 0.0f, rot);
    }


    void Update()
    {
        
    }
}
