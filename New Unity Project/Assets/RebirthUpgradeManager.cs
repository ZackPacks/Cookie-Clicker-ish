using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RebirthUpgradeManager : MonoBehaviour
{
    [SerializeField] GameObject rstartpb;
    [SerializeField] GameObject upg1b;
    [SerializeField] GameObject upg1pb;
    [SerializeField] GameObject upg2b;
    [SerializeField] GameObject upg2pb;
    [SerializeField] GameObject upg3b;
    [SerializeField] GameObject upg3pb;
    [SerializeField] GameObject upg4b;
    [SerializeField] TextMeshProUGUI pointstext;

    static int upgc = 0;
    static bool r = false;
    static bool one = false;
    static bool two = false;
    static bool three = false;
    static bool four = false;

    void Start()
    {
        rstartpb.SetActive(!r);
        upg1b.SetActive(r);
        upg1pb.SetActive(!one);
        upg2b.SetActive(r);
        upg2pb.SetActive(!two);
        upg3b.SetActive(r);
        upg3pb.SetActive(!three);
        upg4b.SetActive(four);

    }
    public void rstart()
    {
        if (Uis.points >= 1)
        {
            Uis.points -= 1;
            Uis.cpsmulti *= 2;
            rstartpb.SetActive(false);
            upg1b.SetActive(true);
            upg2b.SetActive(true);
            upg3b.SetActive(true);
            r = true;
        }
    }
    public void upg1()
    {
        if (Uis.points >= 2)
        {
            Uis.points -= 2;
            Uis.cookiesperclickmulti *= 2;
            upg1pb.SetActive(false);
            upgc++;
            showwin();
            one = true;
        }

    }
    public void upg2()
    {
        if (Uis.points >= 1)
        {
            Uis.points -= 1;
            Uis.farms = 3;
            upg2pb.SetActive(false);
            upgc++;
            showwin();
            two = true;
        }

    }
    public void upg3()
    {
        if (Uis.points >= 2)
        {
            Uis.points -= 2;
            Uis.cpsmulti *= 2;
            upg3pb.SetActive(false);
            upgc++;
            showwin();
            three = true;
        }


    }
    public void upg4()
    {
        if (Uis.points >= 10)
        {
            SceneManager.LoadScene("End");
        }

    }
    void showwin()
    {
        if (upgc == 3)
        {
            upg4b.SetActive(true);
            four = true;
        }
    }
    void Update()
    {
        pointstext.text = "Points: " + Uis.points.ToString("0.00");
    }
}
