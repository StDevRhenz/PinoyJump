using UnityEngine;
//using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private SpriteRenderer spriteRenderer;
    public Sprite jumpUp;
    public Sprite jumpDown;

    void Start()
    {
        t = gameObject.transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = jumpDown;
        Debug.Log(t.position.y);
        cx = t.position.x;
        cz = t.position.z;
    }

    float cx, cz;
    Transform t;
    [SerializeField]
    float starting_speed;

    float speed = 0;

    [SerializeField]
    float speed_changing_ratio;

    bool fall = false;



    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                //t.position = new Vector3(cx, t.position.y+speed, cz);
                spriteRenderer.sprite = jumpUp;
                speed = starting_speed;
                fall = false;
            }
        }

        if (speed > 0 && !fall)
        {
            t.position = new Vector3(cx, t.position.y + speed, cz);
            speed -= speed_changing_ratio;
            if (speed <= 0) 
            {
                spriteRenderer.sprite = jumpDown;
                fall = true;
            }
        }

        if (fall)
        {
            t.position = new Vector3(cx, t.position.y - speed, cz);
            speed += speed_changing_ratio;
        }
    }

}
