using UnityEngine;
using UnityEngine.Networking;


public class UpRaioBomba : NetworkBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //collision.GetComponent<BombaSpawner>().AumentoRaioBomba();
            Destroy(gameObject);

        }
    }
}
