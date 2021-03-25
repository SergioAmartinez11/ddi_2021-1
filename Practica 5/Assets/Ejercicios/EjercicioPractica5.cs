using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class EjercicioPractica5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();
        lista1.Add(1);
        lista1.Add(23);
        lista1.Add(356);
        lista1.Add(2340);
        lista2.Add(4);
        lista2.Add(1);
        lista2.Add(2);
        lista2.Add(1);
        lista2.Add(2);

      //  Debug.Log("Ejercicio 1:");
       // Debug.Log(numParDigitos(lista1));
        Debug.Log("Ejercicio 2. El numero diferente es: ");
        Debug.Log(numParesEncontrados(lista2));

    }

    // corregir
    int numParDigitos(List<int> nums)
    {   
        int result = 0;
        nums.Sort();
       /* for(int i=0; i<nums.Count;i++)
        {
            
        }*/
       
        return result;      
    }
    int numParesEncontrados(List<int> nums)
    {
        nums.Sort();
        int x,y;

        x = nums[0];
        y = nums[nums.Count-1];
        if(x != nums[1])
            return x;
        if(y != nums[nums.Count-2])
            return y;

        for(int i=1;i < nums.Count-1; i++)
        {
            x = nums[i];
            if(x != nums[i-1] && x != nums[i+1])
                return x;
        }
        return 0;
    }   
}
