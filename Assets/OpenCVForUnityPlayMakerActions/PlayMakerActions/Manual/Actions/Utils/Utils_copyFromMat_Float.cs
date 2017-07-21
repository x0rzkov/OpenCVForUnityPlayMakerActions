using UnityEngine;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("static void OpenCVForUnity.Utils.copyFromMat< float > ( Mat mat, List< float > array )")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "mat")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "array")]
    public class Utils_copyFromMat_Float : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            mat;

        [HutongGames.PlayMaker.ActionSection ("[arg2] List<float>(Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray
            array;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            mat = null;
            array = null;
            everyFrame = false;

        }


        public override void OnEnter ()
        {
            DoProcess ();

            if (!everyFrame)
            {
                Finish ();
            }
        }

        public override void OnUpdate ()
        {
            DoProcess ();
        }

        void DoProcess ()
        {
            if (!(mat.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("mat is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_mat = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (mat);

            Utils.copyFromMat<float> (wrapped_mat, array.floatValues);

        }

    }

}