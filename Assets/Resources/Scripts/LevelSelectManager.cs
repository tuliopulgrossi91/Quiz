using UnityEngine;

public class LevelSelectManager : MonoBehaviour
{
    public static string calc;

    public void LevelSelect(int level)
    {
        switch (level)
        {
            case 0:
                calc = "+";
                break;
            case 1:
                calc = "-";
                break;
            case 2:
                calc = "x";
                break;
            case 3:
                calc = "/";
                break;
        }
    }
}