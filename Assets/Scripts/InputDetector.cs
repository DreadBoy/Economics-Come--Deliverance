using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class InputDetector : MonoBehaviour
{

    public float minSwipeDistY;
    public float minSwipeDistX;

    private Vector2 startPos;

    public bool emulate = false;

    public enum Direction
    {
        up,
        down,
        right,
        left,
        none
    }

    public static Direction direction = Direction.none;

    void Update()
    {
        #if UNITY_STANDALONE_WIN
            PC();
        #endif
        #if UNITY_EDITOR
            PC();
        #endif
        #if UNITY_ANDROID
            Android();
        #endif

    }
    private void PC()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            direction = Direction.up;
        else
            direction = Direction.none;

    }
    private void Android()
    {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                    direction = Direction.up;
                else
                    direction = Direction.none;
            }
            else
                direction = Direction.none;
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(100, 100, 100, 300));
        GUILayout.BeginVertical();

        GUILayout.Label(direction.ToString());

        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
}