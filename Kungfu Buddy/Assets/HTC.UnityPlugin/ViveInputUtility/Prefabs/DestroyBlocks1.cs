using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks1 : MonoBehaviour {

    // Use this for initialization
    //public GameObject ColliderName;
    public GameObject explodeObject;


	void OnTriggerEnter(Collider Col)
    {
		if(Col.gameObject.tag == "Hand")
        {
            LessonManager.instance.NumberOfTimes++;
            StartCoroutine(ExplodeThenDisappear());
        }
	}

    IEnumerator ExplodeThenDisappear()
    {
        explodeObject.SetActive(true);
        yield return new WaitForSeconds(.75f);
        Destroy(transform.parent.gameObject);
    }

}

