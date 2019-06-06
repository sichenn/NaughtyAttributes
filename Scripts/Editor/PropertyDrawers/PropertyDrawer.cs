using UnityEditor;

namespace NaughtyAttributes.Editor
{
    public abstract class PropertyDrawer
    {
        public abstract void DrawProperty(SerializedProperty property, UnityEngine.GUIContent label);

        public virtual void ClearCache()
        {

        }
    }
}
