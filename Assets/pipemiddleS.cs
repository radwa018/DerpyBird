using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class pipemiddleS : MonoBehaviour
{
    public logicmanagerscript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic =GameObject.FindGameObjectWithTag("Logic").GetComponent<logicmanagerscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3){
         logic.addscore(1);
        }
        
    }
}
