using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTankController : MonoBehaviour, ITankControl
{
    protected ITankBody Body;
    protected ITankGun Gun;

    protected float body_angle;
    protected float gun_angle;
    protected Rigidbody rb;
    protected Transform t;

    private float ls_xinput;
    private float ls_yinput;
    private float rs_xinput;
    private float rs_yinput;
    private bool shoot;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ls_xinput = Input.GetAxis("Horizontal");
        ls_yinput = Input.GetAxis("Vertical");
        rs_xinput = Input.GetAxis("Mouse X");
        rs_yinput = Input.GetAxis("Mouse Y");
        shoot = Input.GetButton("Fire1");
	}

    private void FixedUpdate()
    {
        Move(ls_xinput, ls_yinput);
        Aim(rs_xinput, rs_yinput);
        if (shoot) Shoot();
    }

    public void Aim(double X, double Y)
    {
        Gun.Aim(X, Y);
    }

    public void Move(double X, double Y)
    {
        Body.Move(X, Y);
    }

    public void Shoot()
    {
        Gun.Shoot();
    }
}
