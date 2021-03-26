using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shopMenu;
    public Animator animator;

    public void OpenShopMenu()
    {
        shopMenu.SetActive(true);
    }

    public void CloseShopMenu()
    {
        shopMenu.SetActive(false);
    }

    public void ClickBuy()
    {
        animator.SetTrigger("Click");
    }

}
