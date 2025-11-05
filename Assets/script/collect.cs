using UnityEngine;
using UnityEngine.Animations;

public class collect : MonoBehaviour
{
    public float collected = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("collect"))
        {
            Destroy(collision.gameObject);
            collected++;
            Debug.Log(collected);
        }
        
    }
}
