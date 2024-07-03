using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string currentName;
    

    public List<string> names = new List<string>();
    public List<int> points = new List<int>();

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadName();
    }

    [System.Serializable]
    class SaveData
    {
        public List<string> names;
        public List<int> points;
    }

    public void SaveName()
    {
        SaveData data = new SaveData();
        data.names = names;
        data.points = points;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText("C:\\Users\\onur\\Desktop" + "\\savefile.json", json);
    }

    public void LoadName()
    {
        string path = "C:\\Users\\onur\\Desktop" + "\\savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            names = data.names;
            points = data.points;
        }
        else
        {
            names = new List<string> { "Empty", "Empty", "Empty", "Empty", "Empty" };
            points = new List<int> { 0, 0, 0, 0, 0 };
        }
    }
}
//Application.persistentDataPath + "/savefile.json;"