using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    [SerializeField] private GameObject objects = null;
    [SerializeField] private GameObject dirLight = null;
    [SerializeField] private GameObject spotLight = null;
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
            ghostObject.gameObject.name += " ghost";
            ToDark();
        }
    }

    public void ToDark(bool active = true)
    {
        if (dirLight)
            dirLight.SetActive(!active);
        if (spotLight)
            spotLight.SetActive(active);

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


    public void endOfGame(bool win = true)
    {
        Debug.Log("end of game : win ? " + win);
    }
}
