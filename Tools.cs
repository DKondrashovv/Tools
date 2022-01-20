using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ForTools
{


    public static class Tools
    {
        public static void AddPositionX(this Transform transform, float x)
        {
            Vector3 newPosition = new Vector3(x + transform.position.x, 0, 0);
            transform.position += newPosition;  
        }

    }
}    

