

using UnityEngine;

//public class SphericalCoordinates
//{
//    //�������� �ּҰ�/�ִ밪
//    float minRadius = 3f;
//    float maxRadius = 20f;

//    //�������� �ּҰ�/�ִ밪
//    float minAzimuth = 0f;
//    float maxAzimuth = 360f;

//    //�Ӱ��� �ּҰ�/�ִ밪
//    float minElevation = 0f;
//    float maxElevation = 90f;

//    //������
//    float radius;
//    public float Radius
//    {
//        get { return radius; }
//        set
//        {
//            //�ּҰ��� �ִ밪 ������ ���� �Ҵ�
//            radius = Mathf.Clamp(value, minRadius, maxRadius);  
//        }
//    }

//    //������
//    float azimuth;
//    public float Azimuth
//    {
//        get { return azimuth; }
//        set
//        {
//            //�ִ밢���� �ּҰ��� �� ������ �ݺ�
//            azimuth = Mathf.Repeat(value, maxRadius - minRadius);
//        }
//    }

//    //�Ӱ�
//    float elevation;
//    public float Elevation
//    {
//        get { return elevation; }
//        set
//        {
//            elevation = Mathf.Clamp(value, minElevation, maxElevation);
//        }
//    }
//}


public class SphericalCoordinates
{
    //������
    float radius;
    //������
    float azimuth;
    //�Ӱ�
    float elevation;

    public SphericalCoordinates(Vector3 cartesianCoordinates)
    {
        radius = cartesianCoordinates.magnitude;
        // ������
        azimuth = Mathf.Atan2(cartesianCoordinates.z, cartesianCoordinates.x);
        // �簢
        elevation = Mathf.Asin(cartesianCoordinates.y / radius);
    }

    public Vector3 ToCartesian
    {
        get
        {
            float a = radius * Mathf.Cos(elevation);
            return new Vector3(a* Mathf.Cos(azimuth), radius * Mathf.Sin(elevation), a * Mathf.Sin(azimuth));
        }
    }

    public SphericalCoordinates Rotate(float newAzimuth, float newElevation)
    {
        azimuth += newAzimuth;
        elevation += newElevation;
        return this;
    }
}
