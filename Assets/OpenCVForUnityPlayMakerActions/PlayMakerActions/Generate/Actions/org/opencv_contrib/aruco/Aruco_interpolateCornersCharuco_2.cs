using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_aruco")]
    [HutongGames.PlayMaker.Tooltip ("public static int interpolateCornersCharuco (List<Mat> markerCorners, Mat markerIds, Mat image, CharucoBoard board, Mat charucoCorners, Mat charucoIds, Mat cameraMatrix)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "markerCorners")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "markerIds")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "image")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.CharucoBoard), "board")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "charucoCorners")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "charucoIds")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "cameraMatrix")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "storeResult")]
    public class Aruco_interpolateCornersCharuco_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] List<Mat>(Array(Mat))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmArray markerCorners;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject markerIds;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject image;

        [HutongGames.PlayMaker.ActionSection ("[arg4] CharucoBoard")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.CharucoBoard))]
        public HutongGames.PlayMaker.FsmObject board;

        [HutongGames.PlayMaker.ActionSection ("[arg5] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject charucoCorners;

        [HutongGames.PlayMaker.ActionSection ("[arg6] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject charucoIds;

        [HutongGames.PlayMaker.ActionSection ("[arg7] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject cameraMatrix;

        [HutongGames.PlayMaker.ActionSection ("[return] int")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            markerCorners = null;
            markerIds = null;
            image = null;
            board = null;
            charucoCorners = null;
            charucoIds = null;
            cameraMatrix = null;
            storeResult = null;
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

            List<OpenCVForUnity.Mat> wrapped_markerCorners = new List<OpenCVForUnity.Mat> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (markerCorners, wrapped_markerCorners);

            if (!(markerIds.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("markerIds is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_markerIds = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (markerIds);

            if (!(image.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("image is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_image = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (image);

            if (!(board.Value is OpenCVForUnityPlayMakerActions.CharucoBoard))
            {
                LogError ("board is not initialized. Add Action \"newCharucoBoard\".");
                return;
            }
            OpenCVForUnity.CharucoBoard wrapped_board = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.CharucoBoard, OpenCVForUnity.CharucoBoard> (board);

            if (!(charucoCorners.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("charucoCorners is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_charucoCorners = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (charucoCorners);

            if (!(charucoIds.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("charucoIds is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_charucoIds = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (charucoIds);

            if (!(cameraMatrix.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("cameraMatrix is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_cameraMatrix = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (cameraMatrix);

            storeResult.Value = OpenCVForUnity.Aruco.interpolateCornersCharuco (wrapped_markerCorners, wrapped_markerIds, wrapped_image, wrapped_board, wrapped_charucoCorners, wrapped_charucoIds, wrapped_cameraMatrix);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.Mat, OpenCVForUnityPlayMakerActions.Mat> (wrapped_markerCorners, markerCorners);


        }

    }

}