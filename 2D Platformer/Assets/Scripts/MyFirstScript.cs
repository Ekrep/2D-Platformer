using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // '>' ->buyuktur
    // '<' ->kucuktur
    // '==' ->esittir
    // '!=' ->esit degildir
    // '>=' ->buyuk esittir
    // '<=' ->kucuk esittir
    // '&&' ->ve
    // '||' ->veya
    // '!' ->degil
    // %  ->mod alir
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int myInt1;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update() 
    {
        switch (myInt1)
        {
            case 1:
                Debug.Log("myInt1 is 1");
                break;
            case 2:
                Debug.Log("myInt1 is 2");
                break;
            case 3:
                Debug.Log("myInt1 is 3");
                break;
            case 4:
                Debug.Log("myInt1 is 4");
                break;
            case 5:
                Debug.Log("myInt1 is 5");
                break;
            default:
                Debug.Log("myInt1 is not between 1 and 5");
                break;
        }
    }
}
