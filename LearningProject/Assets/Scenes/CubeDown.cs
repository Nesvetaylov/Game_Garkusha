using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDown : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;
    public GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        print("������� ������� ��� �������� �������:");
        print("1 - ������� ���");
        print("2 - ������� �����");
        print("3 - ������� �������");
        print("4 - ������� �������");
        print("Escape - ����� �� ����������");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Destroy(cube);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Destroy(sphere);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Destroy(capsule);
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Destroy(cylinder);
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            print("=== Press Escape ===");
            Application.Quit();
        }
    }
}