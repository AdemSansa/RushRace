
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
public class CubeMovement : MonoBehaviour
{
   
    private void Update()
    {
        
        RotatePlayer();

    }

    public Vector3 target;
    Vector3 sideMouvement=Vector3.zero;
    public bool moving;

    public float oldDistance,distance;
    void RotatePlayer()
    {
        Vector3 movement= new Vector3() ;
        if(moving)
        {
            distance=Mathf.Abs(transform.position.x-target.x);
            if(distance<=0.1f || distance>oldDistance)
            {
                moving=false;
                
                sideMouvement=Vector3.zero;
            }
            oldDistance=distance;
        }
        else{
            if (Input.GetKeyDown(KeyCode.LeftArrow)&& transform.position.x>-9)
        {
            movement = new Vector3(-5f, 0f, 0f);
            target=new Vector3(transform.position.x-5f, 0f, 0f);
            moving=true;
            sideMouvement=Vector3.right*-1;
            oldDistance=Mathf.Abs(transform.position.x-target.x);

        }else
        {
            if (Input.GetKeyDown(KeyCode.RightArrow)&& transform.position.x<9)
            {
                movement = new Vector3(5f, 0f, 0f);
                target=new Vector3(transform.position.x+5f, 0f, 0f);
                moving=true;
                sideMouvement=Vector3.right;
                oldDistance=Mathf.Abs(transform.position.x-target.x);
            }
            
        }
        }
        //float horizontal = Input.GetAxis("Horizontal");
        
        

        Vector3 forwardmove = transform.forward*speed*Time.deltaTime+sideMouvement*slideSpeed*Time.deltaTime;
         rb.MovePosition(rb.position+forwardmove);   
            
            
          

    }
    void SlidePlayer()
{
    // Left and right movement
    float horizontal = Input.GetAxis("Horizontal");

    if (horizontal < 0 && transform.position.x > -9)
    {
        // Slide to the left
        transform.Translate(Vector3.left * 5f * Time.deltaTime);
    }
    else if (horizontal > 0 && transform.position.x < 9)
    {
        // Slide to the right
        transform.Translate(Vector3.right * 5f * Time.deltaTime);
    }
}
    public float speed = 5 ;
    public float slideSpeed =5;
    public Rigidbody rb;
    float horizontalInput;
    private void FixedUpdate() {
     
    }
  
        
  


      
}
