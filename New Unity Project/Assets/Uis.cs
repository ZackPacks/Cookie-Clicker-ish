using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Uis : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI cookieAmount;
    [SerializeField] TextMeshProUGUI farmUpg;
    [SerializeField] TextMeshProUGUI facUpg;
    [SerializeField] TextMeshProUGUI bankUpg;
    [SerializeField] TextMeshProUGUI rebutton;
    [SerializeField] GameObject Manager;

    public double cookies = 0;
    static public int cookiesperclickmulti = 1;
    static public int farms = 0;
    double farmp = 100;
    int factories = 0;
    double facp = 500;
    int cookiegain = 0;
    double bankp = 2500;
    int banks = 0;
    double pointspot = 0;
    public static double points = 0;
    static public int cpsmulti = 1;
    public void ClickedCookie()

    {
        cookies += 1 * cookiesperclickmulti;
        frame();
        
    }
    void frame()
    {
        cookieAmount.text = "Cookies: " + cookies.ToString();
        farmUpg.text = "\r\nFarm\r\nCost:" + farmp.ToString() + " Cookies\r\n\r\n";
        facUpg.text = "\r\nFactory\r\nCost:" + facp.ToString() + " Cookies\r\n\r\n";
        bankUpg.text = "\r\nBank\r\nCost:" + bankp.ToString() + " Cookies\r\n\r\n";
    } 
    public void FarmPurchased()
    {
        if (cookies >= farmp)
        {
            farms++;
            cookies = Math.Round(cookies - farmp);
            farmp = Math.Round(farmp * 1.07);
            frame();
        }
    }

    public void FactoryPurchased()
    {
        if (cookies >= facp)
        {
            factories++;
            cookies = Math.Round(cookies - facp);
            facp = Math.Round(facp * 1.17);
            frame();
        }
    }
    public void BankPurchased()
    {
        if (cookies >= bankp)
        {
            banks++;
            cookies = Math.Round(cookies - bankp);
            bankp = Math.Round(bankp * 1.17);
            frame();
        }
    }
    void CookieUpdate()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            cookiegain = (farms * 5 + factories * 25 + banks * 125) * cpsmulti;
            cookies += cookiegain;
            frame();
            pointspot = Math.Sqrt(cookies / 10000);
            if (rebutton)
            {
                if (pointspot.ToString().Length >= 4)
                { rebutton.text = "Rebirth:\r\nCurrent amount:\r\n" + pointspot.ToString().Substring(0, 4) + "\r\nmin 1 required"; }
            }
        }
    }
    void Start()
    {
        CookieUpdate();
        InvokeRepeating("CookieUpdate", .01f, 1.0f);
    }

    void Update() 
    {
    }

    public void rebirth()
    {
        if (pointspot >= 1)
        {
            banks = 0;
            bankp = 2500;
            farms = 0;
            farmp = 100;
            factories = 0;
            facp = 500;
            points = pointspot;
            pointspot = 0;
            cookies = 0;
            cookiegain = 0;
            SceneManager.LoadScene("Rebirth");
        }
    }
}