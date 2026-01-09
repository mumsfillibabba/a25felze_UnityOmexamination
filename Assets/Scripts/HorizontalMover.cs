using UnityEngine;

public class HorizontalMover : MonoBehaviour
{
    public float speed = 1f;
    private int direction = 1;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 3f)
        {
            direction *= -1;
            timer = 0f;
        }

        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }
}