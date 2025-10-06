using UnityEngine;

public class SpawnBala : MonoBehaviour
{
    [SerializeField]private GameObject bala;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Disparar", 2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Disparar()
    {
        GameObject newBala = Instantiate(bala, transform.position, transform.rotation);
        Destroy(newBala, 5f);
    }
}
