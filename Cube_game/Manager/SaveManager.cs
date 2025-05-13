using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace Manager
{
    class SaveManager
    {
        public static readonly SaveManager Instance = new SaveManager();
        public SaveData Data { get; private set; }
        private string SavePath => Path.Combine(Application.persistentDataPath, "SaveFile.json");
    
        public void Load()
        {
            if (!File.Exists(SavePath))
            {
                Data = new SaveData();
                return;
            }
        
            var json = File.ReadAllText(SavePath);
            Data = JsonConvert.DeserializeObject<SaveData>(json);
        }

        private void Save()
        {
            var json = JsonConvert.SerializeObject(Data);
            File.WriteAllText(SavePath,json);
        }

        public void SaveHighScoreForLevel(int level, float highScore)
        {
            Data.HighScores[level] = highScore;
            Save();
        }

        public float GetHighScoreForLevel(int level)
        {
            if (!Data.HighScores.TryGetValue(level, out float highScore))
                return 0;
            return highScore;
        }
    }
}