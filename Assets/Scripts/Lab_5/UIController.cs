using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    VisualElement home, select;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        home = GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("MainMenu");
        select = GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("SelectMenu");

        home.style.display = DisplayStyle.Flex;
        select.style.display = DisplayStyle.None;

        Button playButton = home.Q<Button>("Play");
        playButton.RegisterCallback<ClickEvent>(PlayButton);
        Button selectButton = home.Q<Button>("Select");
        selectButton.RegisterCallback<ClickEvent>(SelectButton);
        Button backButton = select.Q<Button>("Back");
        backButton.RegisterCallback<ClickEvent>(BackMainMenu);

        Button level1Button = select.Q<Button>("Level_1");
        level1Button.RegisterCallback<ClickEvent>(Level_1);
        Button level2Button = select.Q<Button>("Level_2");
        level2Button.RegisterCallback<ClickEvent>(Level_2);
        Button level3Button = select.Q<Button>("Level_3");
        level3Button.RegisterCallback<ClickEvent>(Level_3);
    }


    void PlayButton(ClickEvent evt)
    {
        SceneManager.LoadScene("Lab_5");
    }

    void SelectButton(ClickEvent evt)
    {
        home.style.display = DisplayStyle.None;
        select.style.display = DisplayStyle.Flex;
    }

    void BackMainMenu(ClickEvent evt)
    {
        home.style.display = DisplayStyle.Flex;
        select.style.display = DisplayStyle.None;
    }

    void Level_1(ClickEvent evt)
    {
        SceneManager.LoadScene("Lab_5");
    }

    void Level_2(ClickEvent evt)
    {
        SceneManager.LoadScene("Lab_4");
    }

    void Level_3(ClickEvent evt)
    {
        SceneManager.LoadScene("Lab_3");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
