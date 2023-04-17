using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool collectedKey;
    public int leave_count;
    
    public void Awake()
    {
        collectedKey = false;
        leave_count = 0;
    }
    public void setKey()
    {
        collectedKey = true;
    }
    public void collectLeave()
    {
        leave_count++;
    }

}
