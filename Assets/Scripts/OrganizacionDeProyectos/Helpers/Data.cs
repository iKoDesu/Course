namespace UnityEngine.DataController
{
    public static class Data
    {
        public static int maxLoads;
        public static void SaveData(int id, int value)
        {
            PlayerPrefs.SetInt(id.ToString(), value);
        }
        public static int LoadData(int id)
        {
            return PlayerPrefs.GetInt(id.ToString());
        }
    }
}
