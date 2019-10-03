using UnityEngine;

public class Level : MonoBehaviour
{
    public Animator[] ani_Panel;
    public Animator[] ani_Text;
    public static bool paused;

    public void SelectAction(int x)
    {
        switch (x)
        {
            case 0:
                // pause
                paused = true;
                ani_Panel[0].SetBool("question", false);
                ani_Panel[1].SetBool("pause", true);

                ani_Panel[0].enabled = true;
                ani_Panel[1].enabled = true;

                for (int i = 0; i < 7; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }

                for (int i = 7; i < 10; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                break;
            case 1:
                // resume
                paused = false;
                ani_Panel[0].SetBool("question", true);
                ani_Panel[1].SetBool("pause", false);

                ani_Panel[0].enabled = true;
                ani_Panel[1].enabled = true;

                for (int i = 0; i < 7; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }

                for (int i = 7; i < 10; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }
                break;
            case 2:
                // settings on
                ani_Panel[1].SetBool("pause", false);
                ani_Panel[2].SetBool("settings", true);

                ani_Panel[1].enabled = true;
                ani_Panel[2].enabled = true;

                for (int i = 7; i < 10; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }

                for (int i = 10; i < 14; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                break;
            case 3:
                // settings off
                ani_Panel[1].SetBool("pause", true);
                ani_Panel[2].SetBool("settings", false);

                ani_Panel[1].enabled = true;
                ani_Panel[2].enabled = true;

                for (int i = 7; i < 10; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                for (int i = 10; i < 14; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }
                break;
            case 4:
                // new question off
                ani_Panel[0].SetBool("newquestion", false);
                ani_Panel[0].enabled = true;

                for (int i = 0; i < 7; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", false);
                }
                break;
            case 5:
                // new question on
                ani_Panel[0].SetBool("newquestion", true);
                ani_Panel[0].enabled = true;

                for (int i = 0; i < 7; i++)
                {
                    ani_Text[i].enabled = true;
                    ani_Text[i].SetBool("show", true);
                }
                break;
        }
    }
}