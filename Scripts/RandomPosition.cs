using System.Collections;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RePositionWithDelay());
    }
    
    IEnumerator RePositionWithDelay()
    {
        while (true)
        {
            SetRandomPosition();
            yield return new WaitForSeconds(100f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        SetRandomPosition();
    }
    void SetRandomPosition()
    {
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Debug.Log("X,Z: " + x.ToString("F2") + ", " + z.ToString("F2"));
        transform.position = new Vector3(x, 0.0f, z);
    }
}