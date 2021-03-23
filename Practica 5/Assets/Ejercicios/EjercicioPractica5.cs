using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class EjercicioPractica5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums1 = {1,23,356,1,2340};
        int[] nums2 = {4,1,2,1,2};
        Debug.Log("Ejercicio 1:");
        Debug.Log(numParDigitos(nums1));
        Debug.Log("Ejercicio 2:");
        Debug.Log(numParesEncontrados(nums2));

    }

    // Update is called once per frame
    int numParDigitos(int[] nums)
    {
        int result = 0;
        int x;
        int divisor = 10;
        int comparador = 0;

        for(int i=0;i<nums.Length;i++)
        {
            divisor = 10;
            x = nums[i]/divisor;

            while(x > comparador)
            {
                result +=1;
                divisor = divisor*100;
                comparador *= 100;
                x = nums[i]/divisor;      
            }
        }
        return result;      
    }
    int numParesEncontrados(int[] nums)
    {
        int pos = -1;
        int x;

        for(int i=0;i < nums.Length;i++)
        {   
            x = nums[i];
            for(int j = i+1;j<nums.Length;j++)
            {
                if(x != nums[j])
                {
                    pos = i;    
                }
            }
        }
        return nums[pos];
    }
}
