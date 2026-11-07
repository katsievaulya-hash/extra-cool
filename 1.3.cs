using UnityEngine;

public class HintOnce : MonoBehaviour
{
    public GameObject hintPanel;
    public int shows = 0;

    void Start()
    {
        do
        {
            shows++;
            hintPanel.SetActive(true);
            Debug.Log("Hint shown: " + shows);
        } 
        while (shows < 1); // ВАЖНО: точка с запятой в конце обязательна!

        hintPanel.SetActive(false);
        Debug.Log("Hint closed");
    }
}