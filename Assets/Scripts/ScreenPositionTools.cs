using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;

public static class ScreenPositionTools
{
    public static Vector3 RandomScreenLocation()
    {
        float randomX = Random.Range(0, Screen.width);
        float randomY = Random.Range(0, Screen.height);

        return new Vector3(randomX, randomY, 10);
    }

    public static Vector3 RandomWorldLocation(Camera camera)
    {
        Vector3 randomScreenLocation = RandomScreenLocation();
        return camera.ScreenToWorldPoint(randomScreenLocation);
    }

    public static Vector3 RandomTopOfScreenLocation()
    {
        float randomX = Random.Range(0, Screen.width);
        return new Vector3(randomX, Screen.height, 10);
    }

    public static Vector3 RandomTopOfScreenWorldLocation(Camera camera)
    {
        Vector3 randomTopOfScreenLocation = RandomTopOfScreenLocation();
        return camera.ScreenToWorldPoint(randomTopOfScreenLocation);
    }

    public static Vector3 RandomEdgeOfScreenLocation(string direction)
    {
        float posX = 0.0f;
        float posY = 0.0f;
        if ( direction.Equals("top") )
        {
            posX = Random.Range(0, Screen.width);
            posY = Screen.height;
        }

        else if (direction.Equals("bottom"))
        {
            posX = Random.Range(0, Screen.width);
            posY = 0;
        }
            
        else if (direction.Equals("left"))
        {
            posX = 0;
            posY = Random.Range(0, Screen.height);
        }
            
        else if (direction.Equals("right"))
        {
            posX = Screen.width;
            posY = Random.Range(0, Screen.height);
        }

        return new Vector3(posX, posY, 10);
    }

    public static Vector3 RandomEdgeOfScreenWorldLocation(Camera camera, string direction)
    {
        Vector3 randomEdgeOfScreenLocation = RandomEdgeOfScreenLocation(direction);
        return camera.ScreenToWorldPoint(randomEdgeOfScreenLocation);
    }

    public static Vector3 DirectionToOther(SpriteRenderer spriteRenderer, Vector3 otherWorldPos) // added by Peter 5/10/21
    {
        Vector3 directionVector = (otherWorldPos - spriteRenderer.transform.position).normalized;
        return directionVector;
    }

    public static double DistanceToOther(SpriteRenderer spriteRenderer, Vector3 otherWorldPos) // added by Peter 5/11/21
    {
        Vector3 distanceVector = otherWorldPos - spriteRenderer.transform.position;
        double distance = System.Math.Sqrt(System.Math.Pow(distanceVector.x, 2) + System.Math.Pow(distanceVector.y, 2));
        return distance;
    }

    public static double VectorToAngle(Vector3 directionVector) // added by Peter 5/13/21
    {
        double dirAngle = System.Math.Atan2(directionVector.y, directionVector.x) * (180 / System.Math.PI);
        if (dirAngle < 0)
        {
            dirAngle += 360;
        }
        return dirAngle;
    }
}
