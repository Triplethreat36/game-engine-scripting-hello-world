using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanoiTower : MonoBehaviour
{
    [SerializeField] public int[] peg1 = { 1, 2, 3, 4 };
    [SerializeField] public int[] peg2 = { 0, 0, 0, 0 };
    [SerializeField] public int[] peg3 = { 0, 0, 0, 0 };

    [SerializeField] private int currentPeg = 1;
    [ContextMenu("Move Right")]
    [ContextMenu("Move Left")]


    void MoveRight()
    {
        if (CanMoveRight() == false) return;

        int[] fromArray = GetPeg(currentPeg);
        int fromIndex = GetTopNumberIndex(fromArray);

        if (fromIndex == -1) return;

        int[] toArray = GetPeg(currentPeg + 1);
        int toIndex = GetBottomNumberIndex(fromArray);

        if (toIndex == 1) return;

        MoveNumber(fromArray, toIndex, toArray, toIndex);

    }

    void MoveLeft()
    {
        if (CanMoveleft() == false) return;

        int[] fromArray = GetPeg(currentPeg);
        int fromIndex = GetTopNumberIndex(fromArray);

        if (fromIndex == -1) return;

        int[] toArray = GetPeg(currentPeg - 1);
        int toIndex = GetBottomNumberIndex(fromArray);

        if (toIndex == 1) return;

        MoveNumber(fromArray, toIndex, toArray, toIndex);

    }

    void MoveNumber(int[] fromarr, int fromIndex, int[] toArr, int toIndex)
    {
        int value = fromarr[fromIndex];
        fromarr[fromIndex] = 0;

        toArr[toIndex] = value;
    }
    bool CanMoveRight()
    {
        return currentPeg < 3;
    }
    bool CanMoveleft()
    {
        return currentPeg > 1;
    }
    int[] GetPeg(int pegNumber) 
    {
        if(pegNumber == 1) return peg1;
        if(pegNumber == 2) return peg2;
        return peg3;
    }

    int GetTopNumberIndex(int[] peg)
    {
        for (int i = 0; i < peg.Length; i++)
        {
            if (peg1[i] != 0) return i;
        }
        return -1;
    }
    int GetBottomNumberIndex(int[] peg) 
    {
        for (int i = peg.Length -1; i >= 0; i++)
        {
            if (peg1[i] == 0) return i;
        }
        return -1;
    }
}
