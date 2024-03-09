namespace UnityEngine.Tools
{
    //  Es importante que tenga su propio namespace para separarlo de la logica de todo el proyecto.
    //  La clase y las funciones debe ser estatica para que puedan ser utilizadas desde cualquier lado.
    public static class CourseTools
    {
        public static RectTransform GetRectTransform(this Transform t)
        {
            return t as RectTransform;
        }
    }
}
