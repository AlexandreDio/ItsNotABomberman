using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Explosao2 : NetworkBehaviour
{
    public GameObject Destrutivel;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
        //if (!isLocalPlayer)
        //{
        //    Destroy(this);
        //    return;
        //}
    }

    // Update is called once per frame
    void Update()
    {       
            
    }


    //public void OncollisionEnter (Collider2D collision)
    //{

    //}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Destruivel") || collision.gameObject.CompareTag("Player"))
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Quero cu");
            //Destruivel.SetActive(false);
        }
        //else 
        //{
        //    Destroy(gameObject);
        //    Destroy(this);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destrutivel"))
        {
            print("Destruindo os blocos com o Script Explosao2.cs");
            Destroy(collision.gameObject);
        }
    }
}
