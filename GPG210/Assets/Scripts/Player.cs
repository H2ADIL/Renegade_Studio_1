using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;

    public Bullet_EMP _Bullet;

    public GameObject EMPPrefab;
    public Transform firePosition;

    public int CurrentAmmo_EMP;
    public int CurrentAmmo_Noisemaker;

    InterfaceController _InterfaceController;

    public bool isDead;

    void Start()
    {
        isDead = false;
    }

    void Update()
    {
        PlayerMovement();

        //Shooting controls
        if (Input.GetMouseButtonDown(0))
        {
            Bullet_EMP _EMP = Instantiate(_Bullet, firePosition.position, firePosition.rotation) as Bullet_EMP;
        }
    }

    public void AmmoPickup(int ammo)
    {
        //myCurrentammo += myCurrentammo
        CurrentAmmo_EMP += ammo;
        CurrentAmmo_Noisemaker += ammo;
    }

    void PlayerMovement()
    {
        //Movement for X Axis
        float horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);

        //Movement for Z Axis
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
