using UnityEngine;
//using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = gameObject.transform;
        Debug.Log(t.position.y);
        cx = t.position.x;
        cz = t.position.z;
    }

    float cx, cz;
    Transform t;

    float speed = 0;

    bool fall = false;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                //t.position = new Vector3(cx, t.position.y+speed, cz);
                speed = 0.18f;
            }
        }

            speed = 0.005f;

            if (speed > 0 && !fall)
            {
                t.position = new Vector3(cx, t.position.y + speed, cz);
                speed -= 0.005f;
                if (speed <= 0) 
                {
                    fall = true;
                }
            }

            if (fall)
            {
                t.position = new Vector3(cx, t.position.y - speed, cz);
                speed += 0.005f;
            }
        }

    }
