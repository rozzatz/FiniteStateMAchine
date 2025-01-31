using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameeNVIRONMENT : MonoBehaviour
{
  private static GameeNVIRONMENT instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints {  get { return checkpoints; } }

  
}
