using TMPro;
using UnityEngine;

public class GetCoin : MonoBehaviour
{

    public int coin ;

    public TextMeshProUGUI UICOINT;  //UICOINT;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        UICOINT.text = "GOLD:" + coin;
        

    }

  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            AddCoin(1);
            Destroy(other.gameObject);
        }

    }

   public void AddCoin(int price)
    {
        coin+=price;
    }
}
