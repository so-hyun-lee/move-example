

using UnityEngine;

//public class SphericalCoordinates
//{
//    //반지름의 최소값/최대값
//    float minRadius = 3f;
//    float maxRadius = 20f;

//    //방위각의 최소값/최대값
//    float minAzimuth = 0f;
//    float maxAzimuth = 360f;

//    //앙각의 최소값/최대값
//    float minElevation = 0f;
//    float maxElevation = 90f;

//    //반지름
//    float radius;
//    public float Radius
//    {
//        get { return radius; }
//        set
//        {
//            //최소값과 최대값 사이의 값을 할당
//            radius = Mathf.Clamp(value, minRadius, maxRadius);  
//        }
//    }

//    //방위각
//    float azimuth;
//    public float Azimuth
//    {
//        get { return azimuth; }
//        set
//        {
//            //최대각에서 최소각을 뺀 값으로 반복
//            azimuth = Mathf.Repeat(value, maxRadius - minRadius);
//        }
//    }

//    //앙각
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
    //반지름
    float radius;
    //방위각
    float azimuth;
    //앙각
    float elevation;

    public SphericalCoordinates(Vector3 cartesianCoordinates)
    {
        radius = cartesianCoordinates.magnitude;
        // 방위각
        azimuth = Mathf.Atan2(cartesianCoordinates.z, cartesianCoordinates.x);
        // 양각
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
