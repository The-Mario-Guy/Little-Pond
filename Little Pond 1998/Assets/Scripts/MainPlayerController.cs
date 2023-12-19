using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 4;
    public Rigidbody _rigidBody;
    public Animator anim;

    //[SerializeField] private int _cogs;
    private static MainPlayerController _instance;
    Vector3 movement;
 


    void Start()
    {
        anim = GetComponent<Animator>();

    
    }

    // Update is called once per frame
    void Update()
    {
        //OG UIManager
        Movement();
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);


    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
       
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        

        transform.Translate(xValue, 0f, zValue);

   
    }
    public static MainPlayerController Instance
    {
        get
        {
            if (_instance == null )
            {
                Debug.LogError("Player is Null");
            }
            return _instance;
        }

    }
    private void Awake()
    {
        _instance = this;
    }



}
