using UnityEngine;

public class Toplama : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int sayi1;
    public int sayi2;
    public int toplam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        toplam = sayi1 + sayi2;
        Debug.Log(toplam);
    }
}
