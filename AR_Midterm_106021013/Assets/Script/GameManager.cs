using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("動畫")]
    public Animator aniGirl;
    public Animator aniRobot;
    int hp , damage1=1, damage2=50;
    public Image btn1;
    public Image btn2;
    public Text life;
    bool btn2click;
    


    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        btn2click = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1()//固定public
    {
        print("1");
        aniGirl.SetTrigger("Attack");//unity api animator>method>setTrigger
        aniRobot.SetTrigger("Hurt");
        hp -= damage1;
        if (hp <= 0)
        {
            life.text = "0";
        }
        else
        {
            life.text = hp.ToString();
        }
        
    }

    public void Buttom2()//固定public
    {
        if(btn2click == false)
        {

        }
        else
        {
            print("2");
            aniGirl.SetTrigger("Dance");
            aniRobot.SetTrigger("Die");
            hp -= damage2;
            if(hp <= 0)
            {
                life.text = "0";
            }
            else
            {
                life.text = hp.ToString();
            }

            btn2.enabled = false;
            btn2click = false;
        }
        
    }
}
