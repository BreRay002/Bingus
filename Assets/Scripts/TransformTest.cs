using UnityEngine;

public class TransformTest : MonoBehaviour
{
    public Vector3 position;
    public Vector3 scale;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = position; //positions the square
        transform.rotation = Quaternion.Euler(30, 20, 0); //rotates the square
        transform.localScale = scale; //scales the square
    }
}
