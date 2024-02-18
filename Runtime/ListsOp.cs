/* 
 * 
 * My name's mohammed mellas known by arab and I want to say thanks for downloading my Utils
 * this class is responsible of a Multiple function on diffrent operations on a given List<>
 */

using UnityEngine;
using System.Collections.Generic;

namespace Mellas.Operation
{
    public static class ListsOp
    {
        public static void DeactivateAll(List<Transform> objectToDesactive)
        {
            for (int i = 0; i < objectToDesactive.Count - 1; i++)
            {
                objectToDesactive[i].gameObject.SetActive(false);
            }
        }
        public static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Range(0, n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}