using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonManager : MonoBehaviour {

    public int NumberOfTimes;
    public static LessonManager instance;
    public bool level2 = false;
    public GameObject Level2obj;

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
	}

    IEnumerator HandDown()
    {
        yield return null;
        Level2obj.SetActive(true);
    }

}
