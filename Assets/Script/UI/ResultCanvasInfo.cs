using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultCanvasInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text info = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetData(bool win = true)
    {
        string infostr = "Vous avez ";
        infostr += win ? "gagné !" : "perdu !";

        if (info)
            info.text = infostr;
    }

}
