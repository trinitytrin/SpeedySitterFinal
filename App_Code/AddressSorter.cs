using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Class to sort address aaccording to distance 
/// Author: Tanzila
/// </summary>
public class AddressSorter
{
    public GetDBAddress SortsAddress
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public static void SortAddress(NewAddress[] A, int size)
    {
        try
        {
            QuickSort(A, 0, size - 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Press any key to terminate..");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }

    public static void QuickSort(NewAddress[] A, int left, int right)
    {
        NewAddress pivot = A[left];
        int l = left;
        int r = right;

        while (left < right)
        {
            while (pivot.Distance <= A[right].Distance && left < right)
            {
                right--;
            }

            if (pivot.Distance > A[right].Distance && left < right)
            {
                A[left] = A[right];
                left++;
            }

            while (pivot.Distance >= A[left].Distance && left < right)
            {
                left++;
            }

            if (pivot.Distance < A[left].Distance && left < right)
            {
                A[right] = A[left];
                right--;

            }
        }

        A[left] = pivot;

        if (l < left - 1)
        {
            QuickSort(A, l, left - 1);
        }

        if (right + 1 < r)
        {
            QuickSort(A, right + 1, r);

        }

    }
    public AddressSorter()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}