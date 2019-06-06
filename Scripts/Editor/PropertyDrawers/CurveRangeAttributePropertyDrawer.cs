using UnityEngine;
using UnityEditor;

namespace NaughtyAttributes.Editor
{
    [PropertyDrawer(typeof(CurveRangeAttribute))]
    public class RangeAttributePropertyDrawer : PropertyDrawer
    {
        public override void DrawProperty(SerializedProperty property, GUIContent label)
        {
            var attribute = PropertyUtility.GetAttribute<CurveRangeAttribute>(property);
            UnityEngine.Object target = PropertyUtility.GetTargetObject(property);

            EditorDrawUtility.DrawHeader(property);
            EditorGUILayout.CurveField(property, attribute.color,
            new Rect(0, 0, attribute.width, attribute.height));
        }
    }
}
