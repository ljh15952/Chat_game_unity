using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM : MonoBehaviour
{
    private float ScreenWidth = 720.0f;
    private float ScreenHeight = 1280.0f;
    private UnityEngine.Vector3 scale = Vector2.zero;
    private Matrix4x4 Mat = Matrix4x4.identity;

    void Start()
    {
        scale.x = Screen.width / ScreenWidth;
        scale.y = Screen.height / ScreenHeight;
        scale.z = 1.0f;
    }

    void OnGUI()
    {
        Mat = GUI.matrix;
        GUI.matrix = Matrix4x4.TRS(UnityEngine.Vector3.zero, Quaternion.identity, scale);

        // 그래픽 출력 처리

        GUI.matrix = Mat;
    }

}
