using UnityEngine;
using UnityEngine.Tools;
using UnityEngine.DataController;

namespace Cours.OrganizacionProyecto
{
    public class Helper : MonoBehaviour
    {
        private void Start()
        {
            int maxLoad = Data.maxLoads;
            RectTransform test = CourseTools.GetRectTransform(transform);
            int money = Data.LoadData(1);
            Data.SaveData(1, money);
        }
    }
}
