using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public Text[] text;
    private int s, n1, n2, alt1, alt2, alt3, result;
    private Animator ani;
    private readonly int[] div1 = { 2, 3, 4, 4, 5, 6, 6, 6, 7, 8, 8, 8, 9, 9 };
    private readonly int[] div2 = { 2, 3, 2, 4, 5, 2, 3, 6, 7, 2, 4, 8, 3, 9 };

    void Start()
    {
        ani = GetComponent<Animator>();
        RandomNumbers();
    }

    void Update()
    {
        RandomNumbers();
    }

    void RandomNumbers()
    {
        int r = Random.Range(0, 3); // 0 - 2

        #region CHECK OPERATIONS
        if (LevelSelectManager.calc == "+")
        {
            n1 = Random.Range(1, 10); // 1 - 9
            n2 = Random.Range(1, 10); // 1 - 9
            result = n1 + n2;
        }
        if (LevelSelectManager.calc == "-")
        {
            n1 = Random.Range(1, 10); // 1 - 9
            n2 = Random.Range(1, 10); // 1 - 9
            result = n1 - n2;
        }
        if (LevelSelectManager.calc == "x")
        {
            n1 = Random.Range(1, 10); // 1 - 9
            n2 = Random.Range(1, 10); // 1 - 9
            result = n1 * n2;
        }
        if (LevelSelectManager.calc == "/")
        {
            int d = Random.Range(0, 14); // 0 - 13

            n1 = div1[d];
            n2 = div2[d];
            result = n1 / n2;
        }
        #endregion

        #region CHECK RESULTS
        if (r == 0)
        {
            alt1 = result;

            if (LevelSelectManager.calc == "x")
            {
                alt2 = Random.Range(1, 82); // 1 - 81
                alt3 = Random.Range(1, 82); // 1 - 81
            }
            else
            {
                alt2 = Random.Range(1, 10); // 1 - 9
                alt3 = Random.Range(1, 10); // 1 - 9
            }

            while (alt2 == result || alt3 == result || alt2 == alt3)
            {
                if (LevelSelectManager.calc == "x")
                {
                    alt2 = Random.Range(1, 82); // 1 - 81
                    alt3 = Random.Range(1, 82); // 1 - 81
                }
                else
                {
                    alt2 = Random.Range(1, 10); // 1 - 9
                    alt3 = Random.Range(1, 10); // 1 - 9
                }
            }
        }
        if (r == 1)
        {
            alt2 = result;

            if (LevelSelectManager.calc == "x")
            {
                alt1 = Random.Range(1, 82); // 1 - 81
                alt3 = Random.Range(1, 82); // 1 - 81
            }
            else
            {
                alt1 = Random.Range(1, 10); // 1 - 9
                alt3 = Random.Range(1, 10); // 1 - 9
            }

            while (alt1 == result || alt3 == result || alt1 == alt3)
            {
                if (LevelSelectManager.calc == "x")
                {
                    alt1 = Random.Range(1, 82); // 1 - 81
                    alt3 = Random.Range(1, 82); // 1 - 81
                }
                else
                {
                    alt1 = Random.Range(1, 10); // 1 - 9
                    alt3 = Random.Range(1, 10); // 1 - 9
                }
            }
        }
        if (r == 2)
        {
            alt3 = result;

            if (LevelSelectManager.calc == "x")
            {
                alt1 = Random.Range(1, 82); // 1 - 81
                alt2 = Random.Range(1, 82); // 1 - 81
            }
            else
            {
                alt1 = Random.Range(1, 10); // 1 - 9
                alt2 = Random.Range(1, 10); // 1 - 9
            }

            while (alt1 == result || alt2 == result || alt1 == alt2)
            {
                if (LevelSelectManager.calc == "x")
                {
                    alt1 = Random.Range(1, 82); // 1 - 81
                    alt2 = Random.Range(1, 82); // 1 - 81
                }
                else
                {
                    alt1 = Random.Range(1, 10); // 1 - 9
                    alt2 = Random.Range(1, 10); // 1 - 9
                }
            }
        }
        #endregion

        #region CHANGE TEXT
        text[0].text = n1.ToString(); // TextN1
        text[1].text = LevelSelectManager.calc; // TextA
        text[2].text = n2.ToString(); // TextN2
        text[3].text = alt1.ToString(); // TextAlt1
        text[4].text = alt2.ToString(); // TextAlt2
        text[5].text = alt3.ToString(); //TextAlt3
        #endregion
    }

    public void Select()
    {
        s++;

        if (s > 9)
        {
            SceneManager.LoadScene(0); // load menu
        }
        ani.SetBool("question", false);
    }

    public void NextQuestion()
    {
        if (Level.paused == false)
        {
            RandomNumbers();
            ani.SetBool("question", true);
        }
    }
}