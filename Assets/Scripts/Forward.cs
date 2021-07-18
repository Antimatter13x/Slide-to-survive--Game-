using UnityEngine;

public class Forward : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 1000f;
    public float sideforce = 400f;
    private Touch theTouch;
    private Vector2 touchStartPosition, touchEndPosition;
    // public AudioSource fall_sound;

    /*  void start()
      {
          fall_sound = GetComponent<AudioSource>();
      }
    */

    void FixedUpdate()
    {
        //rb.useGravity = true;
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);

            if (theTouch.phase == TouchPhase.Began)
            {
                touchStartPosition = theTouch.position;
            }

            else if (theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended)
            {
                touchEndPosition = theTouch.position;

                float x = touchEndPosition.x - touchStartPosition.x;
                if (x < 0)
                {
                    rb.AddForce(-(sideforce*2) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }

                else if (x > 0)
                {
                    rb.AddForce((sideforce*2) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.x > -37.94f || rb.position.x < -49.06f)
        {
            //fall_sound.Play();
            FindObjectOfType<GameManager>().EndGame_offroad();
        }
    }
}
