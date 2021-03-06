﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            switch (Character.getInstance().CharacStatus)
            {
                case Character.Status.idle:
                    {
                        switch (Gun.holdGun)
                        {
                            case Gun.gunKind.handGun:
                                {
                                    break;
                                }

                            case Gun.gunKind.shotGun:
                                {
                                    if (ShotGun.getInstance().admitShoot == true) //冷却时间定时器
                                    {
                                        Character.getInstance().shoot();
                                        ShotGun.getInstance().admitShoot = false;

                                        Character.getInstance().CharacAttackMode = Character.AttackMode.shoot;
                                        Character.getInstance().CharacStatus = Character.Status.idleAttack;
                                    }

                                    break;
                                }
                        }

                        break;
                    }
                case Character.Status.move:
                    {
                        switch (Gun.holdGun)
                        {
                            case Gun.gunKind.handGun:
                                {
                                    break;
                                }

                            case Gun.gunKind.shotGun:
                                {
                                    if (ShotGun.getInstance().admitShoot == true) //冷却时间定时器
                                    {
                                        Character.getInstance().shoot();
                                        ShotGun.getInstance().admitShoot = false;

                                        Character.getInstance().CharacAttackMode = Character.AttackMode.shoot;
                                        Character.getInstance().CharacStatus = Character.Status.moveAttack;
                                    }

                                    break;
                                }
                        }

                        break;
                    }
                case Character.Status.jump:
                    {
                        switch (Gun.holdGun)
                        {
                            case Gun.gunKind.handGun:
                                {
                                    break;
                                }

                            case Gun.gunKind.shotGun:
                                {
                                    if (ShotGun.getInstance().admitShoot == true) //冷却时间定时器
                                    {
                                        Character.getInstance().shoot();
                                        ShotGun.getInstance().admitShoot = false;

                                        Character.getInstance().CharacAttackMode = Character.AttackMode.shoot;
                                        Character.getInstance().CharacStatus = Character.Status.jumpAttack;
                                    }

                                    break;
                                }
                        }

                        break;
                    }
            }

        }

        //状态切换
        if ((!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)))
        {
            if (Character.getInstance().CharacAttackMode != Character.AttackMode.disAttack)
            {
                Character.getInstance().CharacStatus = Character.Status.idleAttack;
            }
            return;
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Character.getInstance().CharacAttackMode != Character.AttackMode.disAttack)
            {
                Character.getInstance().CharacStatus = Character.Status.moveAttack;
            }

        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (Character.getInstance().CharacAttackMode != Character.AttackMode.disAttack)
            {
                Character.getInstance().CharacStatus = Character.Status.moveAttack;
            }
        }
    }

    public static void changeAttackMode()
    {
        Character.getInstance().CharacAttackMode = Character.AttackMode.disAttack;
    }
}
