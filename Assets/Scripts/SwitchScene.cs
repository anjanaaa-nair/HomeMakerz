using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void createAccount()
    {
        SceneManager.LoadScene("CreateAccount");
    }
    public void back1()
    {
        SceneManager.LoadScene("Initial");
    }
    public void login()
    {
        SceneManager.LoadScene("Login");
    }
    public void back2()
    {
        SceneManager.LoadScene("Initial");
    }
    public void finish()
    {
        SceneManager.LoadScene("Home");
    }
    public void loginbtn()
    {
        SceneManager.LoadScene("Home");
    }

    //From product listings
    public void back3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //From room listings
    public void back4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    //Click on product type and it will take you to a page that lists down the products
    //takes you to product
    public void ProductType()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Click on room type and it will take you to a page that lists down the products in that room
    public void RoomType()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //Directs from product listings to decription
    public void Product1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Product2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    //Directs from product description page to the product listings
    public void back5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    //Directs to cart from homepage
    public void Cart1()
    {
        SceneManager.LoadScene("Cart");
    }

    //Directs to wishlist from homepage
    //public void Wishlist1()
    //{
    //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    //}

    //Directs to cart from product description page
    public void Cart2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //Directs to wishlist from product description page
    public void Wishlist2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Directs to cart from wishlist page
    public void Cart3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Goes to home page from wishlist page
    public void back6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    //Goes to home page from cart page
    public void back7()
    {
        SceneManager.LoadScene("Home");
    }

    //Directs to cart from checkout
    public void back8()
    {
        SceneManager.LoadScene("Cart");
    }

    //log out
    public void logout()
    {
        SceneManager.LoadScene("Logout");
    }
    //do not log out
    public void back9()
    {
        SceneManager.LoadScene("Home");
    }

    //Directs to cart from product my account page
    public void Cart4()
    {
        SceneManager.LoadScene("Cart");
    }

    //Directs to wishlist from my account page
    public void Wishlist3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    //go to my account from home page
    public void myAccount()
    {
        SceneManager.LoadScene("Profile");
    }

    //go to FAQ from home page
    public void faqs()
    {
        SceneManager.LoadScene("FAQ");
    }

    //go back to home page from account page
    public void back10()
    {
        SceneManager.LoadScene("Home");
    }
    //go back to home page from FAQ page
    public void back11()
    {
        SceneManager.LoadScene("Home");
    }

    //open payment scene
    public void payment()
    {
        SceneManager.LoadScene("Payment");
    }

    //Directs to checkout
    public void Checkout()
    {
        SceneManager.LoadScene("Checkout");
    }

    //Directs to myorders
    public void MyOrder()
    {
        SceneManager.LoadScene("MyOrders");
    }

    //Directs back to home from myorders
    public void FromOrder()
    {
        SceneManager.LoadScene("Home");
    }

    //trigger AR Camera
    public void arCamera()
    {
        SceneManager.LoadScene("ARCamera");
    }

}
