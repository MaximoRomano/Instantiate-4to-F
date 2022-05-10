using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CloneAmount;
    public Text txtcloneamount;

    public void CloneObject()
    {

        CloneAmount = int.Parse(txtcloneamount.text);
        int i = 0;
        while (i < CloneAmount)
        {
            i++;
        }

    }
}
