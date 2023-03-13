using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    [SerializeField] private GameObject objects = null;
    [SerializeField] private bool isDarkEnv = false;

    private Transform ghostObject = null;

    void Start()
    {
        // Set ghost
        if (objects)
        {
            int randomChildIndex = Random.Range(0, objects.transform.childCount);
            ghostObject = objects.transform.GetChild(randomChildIndex);
            ghostObject.gameObject.GetComponent<Invisibility>().SetGhost();
            ToDark();
        }
    }

    public void ToDark(bool active = true)
    {
        isDarkEnv = active;
        for (int i = 0; i < objects.transform.childCount; i++)
        {
            Transform currentChild = objects.transform.GetChild(i);
            currentChild.gameObject.GetComponent<Invisibility>().ToDark(active);
        }
    }

    public void ToLight()
    {
        ToDark(false);
    }


    public void SwitchEnv()
    {
        if (isDarkEnv)
            ToLight();
        else
            ToDark();
    }
}
