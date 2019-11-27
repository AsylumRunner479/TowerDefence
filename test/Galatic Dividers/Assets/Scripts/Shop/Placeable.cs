using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Placeable : MonoBehaviour
    {
        public bool isAvailable = true;
        public Transform pivotPoint;

        public Vector3 GetPivotPoint()
        {
            if (pivotPoint)
                return pivotPoint.position;
            return transform.position;
        }
    }
