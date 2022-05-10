using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputmanager : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField ifusername;
    public Text txtusername;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UserGreetings()
    {
        Debug.Log( int.Parse(txtusername.text) *2);
    }
}
