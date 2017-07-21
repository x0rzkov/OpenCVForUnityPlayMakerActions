using System;
using UnityEngine;
using UnityEditor;
using HutongGames.PlayMakerEditor;
using Object = UnityEngine.Object;

namespace OpenCVForUnityPlayMakerActions
{

    // Test with action that uses an FsmObject variable of AudioClip type. E.g., Set Audio Clip

    [ObjectPropertyDrawer (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint3f))]
    public class MatOfPoint3fObjectPropertyDrawer : OpenCVObjectPropertyDrawer
    {

    }
}
