using UnityEngine;
using UnityEditor;

namespace NaughtyAttributes.Editor
{
    [PropertyDrawer(typeof(VectorRangeAttribute))]
    public class VectorRangePropertyDrawer : PropertyDrawer
    {
        public override void DrawProperty(UnityEditor.SerializedProperty property, UnityEngine.GUIContent label)
        {
            var attribute = PropertyUtility.GetAttribute<VectorRangeAttribute>(property);
            UnityEngine.Object target = PropertyUtility.GetTargetObject(property);
            if (property.propertyType == SerializedPropertyType.Vector3)
            {
                EditorGUILayout.PropertyField(property);
                Vector3 clampedValue = property.vector3Value;
                clampedValue.x = Mathf.Clamp(clampedValue.x, attribute.minValue.x, attribute.maxValue.x); 
                clampedValue.y = Mathf.Clamp(clampedValue.y, attribute.minValue.y, attribute.maxValue.y);
                clampedValue.z = Mathf.Clamp(clampedValue.y, attribute.minValue.z, attribute.maxValue.z);
                property.vector3Value = clampedValue;
            }
            else if (property.propertyType == SerializedPropertyType.Vector2)
            {
                EditorGUILayout.PropertyField(property);
                Vector2 clampedValue = property.vector2Value;
                clampedValue.x = Mathf.Clamp(clampedValue.x, attribute.minValue.x, attribute.maxValue.x); 
                clampedValue.y = Mathf.Clamp(clampedValue.y, attribute.minValue.y, attribute.maxValue.y);
                property.vector2Value = clampedValue;
            }

            else
            {
                EditorGUILayout.HelpBox("VectorRange can only work with vectors", MessageType.Error);
            }
        }
    }

}