#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class Callback : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Callback ()
        {

        }

        public Callback (OpenCVForUnity.Callback nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
