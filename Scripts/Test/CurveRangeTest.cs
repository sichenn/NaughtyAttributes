using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class CurveRangeTest : MonoBehaviour
{
    [CurveRange(-1, -1, 2, 2, EColor.Blue)]
    public AnimationCurve curve;
}
