using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject shop;
    public GameObject inventory;
    public GameObject settings;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shop.SetActive(false);
        inventory.SetActive(false);
        settings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenShop(){
        
        shop.SetActive(true);
    }
    
    public void OpenInventory(){
        
        inventory.SetActive(true);
    }

    public void OpenSettings(){
        
        settings.SetActive(true);
    }

    public void CloseAll(){
        shop.SetActive(false);
        inventory.SetActive(false);
        settings.SetActive(false);
    }
}
