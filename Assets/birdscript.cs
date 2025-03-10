using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public logicmanagerscript logic;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic =GameObject.FindGameObjectWithTag("Logic").GetComponent<logicmanagerscript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) ==true){
            myrigidbody.linearVelocity=Vector2.up *flapstrength;
        }
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
    }
}
