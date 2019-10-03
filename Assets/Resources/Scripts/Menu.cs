using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator[] ani_Panel;
    public Animator[] ani_Text;

    public void SelectAction(int x)
    {
        switch (x)
        {
            case 0:
                // levels on
                ani_Panel[0].SetBool("menu", false);
                ani_Panel[1].SetBool("levels", true);

                ani_Panel[0].enabled = true;
                ani_Panel[1].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }

                for (int i = 5; i < 11; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                break;
            case 1:
                // levels off
                ani_Panel[0].SetBool("menu", true);
                ani_Panel[1].SetBool("levels", false);

                ani_Panel[0].enabled = true;
                ani_Panel[1].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }

                for (int i = 5; i < 11; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }
                break;
            case 2:
                // settings on
                ani_Panel[0].SetBool("menu", false);
                ani_Panel[2].SetBool("settings", true);

                ani_Panel[0].enabled = true;
                ani_Panel[2].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }

                for (int i = 11; i < 15; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                break;
            case 3:
                // settings off
                ani_Panel[0].SetBool("menu", true);
                ani_Panel[2].SetBool("settings", false);

                ani_Panel[0].enabled = true;
                ani_Panel[2].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }

                for (int i = 11; i < 15; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }
                break;
            case 4:
                // credits on
                ani_Panel[0].SetBool("menu", false);
                ani_Panel[3].SetBool("credits", true);

                ani_Panel[0].enabled = true;
                ani_Panel[3].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }

                for (int i = 15; i < 20; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                break;
            case 5:
                // credits off
                ani_Panel[0].SetBool("menu", true);
                ani_Panel[3].SetBool("credits", false);

                ani_Panel[0].enabled = true;
                ani_Panel[3].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }

                for (int i = 15; i < 20; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }
                break;
            case 6:
                // exit on
                ani_Panel[0].SetBool("menu", false);
                ani_Panel[4].SetBool("exit", true);

                ani_Panel[0].enabled = true;
                ani_Panel[4].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }

                for (int i = 20; i < 23; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                break;
            case 7:
                // exit off
                ani_Panel[0].SetBool("menu", true);
                ani_Panel[4].SetBool("exit", false);

                ani_Panel[0].enabled = true;
                ani_Panel[4].enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }

                for (int i = 20; i < 23; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }
                break;
            case 8:
                // confirm exit
                Application.Quit();
                break;
            case 9:
                // load level
                SceneManager.LoadScene(1);
                break;
        }
    }
}