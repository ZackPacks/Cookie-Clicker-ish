using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject Rstart;
    [SerializeField] GameObject Upg1;
    [SerializeField] GameObject Upg2;
    [SerializeField] GameObject Upg3;
    [SerializeField] GameObject Upg4;

    bool rstartb = false;
    bool upg1b = false;
    bool upg2b = false;
    bool upg3b = false;
    bool upg4b = false;

    public void Rstartclick()
    {
        if (rstartb == true)
        {
            rstartb = false;
        }
        else
        {
            rstartb = true;
        }
        active(5);
    }



    void active(int x) // Detta var inte det besta sättet att göra det men jag började ta slut med tid.
    {
        if (x == 1) 
        { 
            upg2b = false; 
            upg3b = false;
            rstartb = false;
            upg4b = false;
        }
        else if (x == 2) 
        { 
            upg1b = false; 
            upg3b = false;
            rstartb = false;
            upg4b = false;
        }
        else if (x == 3) 
        {
            upg1b = false; 
            upg2b = false;
            rstartb = false;
            upg4b = false;
        }
        else if (x == 4)
        {
            upg1b = false;
            upg2b = false;
            upg3b = false;
            rstartb = false;
        }
        else if (x == 5)
        {
            upg1b = false;
            upg2b = false;
            upg3b = false;
            upg4b = false;
        }

        Rstart.SetActive(rstartb);
        Upg1.SetActive(upg1b);
        Upg2.SetActive(upg2b);
        Upg3.SetActive(upg3b);
        Upg4.SetActive(upg4b);
    }

    public void upg1()
    {
        if (upg1b == true)
        { 
            upg1b = false; 
        }
        else
        { 
            upg1b = true; 
        }

        active(1);
    }
    public void upg2()
    {
        if (upg2b == true)
        {
            upg2b = false;
        }
        else
        {
            upg2b = true;
        }

        active(2);
    }
    public void upg3()
    {
        if (upg3b == true)
        {
            upg3b = false;
        }
        else
        {
            upg3b = true;
        }

        active(3);
    }
    public void upg4()
    {
        if (upg4b == true)
        {
            upg4b = false;
        }
        else
        {
            upg4b = true;
        }

        active(4);
    }

    public void back()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
