﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonManager : MonoBehaviour {

    public int NumberOfTimes;
    public static LessonManager instance;
    public bool level2 = false;
    public bool level3 = false;
    public GameObject Level2obj;
    public GameObject Level3obj;

    private void Awake()
    {
        instance = this;
    }
    void Update () {
        if (NumberOfTimes > 2&& level2 ==false)
        {
            StartCoroutine(HandDown());
            level2= true;
        }
        if (NumberOfTimes > 4 && level3 == false)
        {
            StartCoroutine(ReadyPos());
            level3 = true;
        }
    }

    IEnumerator HandDown()
    {
        yield return new WaitForSeconds(2f);
        Level2obj.SetActive(true);
    }

    IEnumerator ReadyPos()
    {
        yield return new WaitForSeconds(2f);
        Level3obj.SetActive(true);
    }
}
