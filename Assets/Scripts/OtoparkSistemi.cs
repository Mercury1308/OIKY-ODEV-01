using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{
    public int süre; //Otoparkta geçirilen süre
    void Start()
    {
        switch (süre)
        {
            case 1:
                Debug.Log("Ücret 120 Türk Lirası");
                break;
            case 2:
                Debug.Log("Ücret 200 Türk Lirası");
                break;
            case 3:
                Debug.Log("Ücret 300 Türk Lirası");
                break;
            case 4:
                Debug.Log("Ücret 400 Türk Lirası");
                break;
            case int n when n >= 5: //Süre 5 saat veya üzeriyse bu kod çalışacak
                Debug.Log("Ücret 550 Türk Lirası");
                break;
            default: //Eğer 0 veya negatif sayı girerse diye bunu ekledim
                Debug.Log("Hizmet veremiyoruz");
                break;
        }
    }
}