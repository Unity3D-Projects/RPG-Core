﻿using Station;
using UnityEngine;

public abstract class BaseSystem : MonoBehaviour
{
   private bool _isInitialized = false;
   protected RpgStation _station;

   public void Init(RpgStation station)
   {
      _station = station;
      if (!_isInitialized)
      {
         _isInitialized = true;
         OnInit();
      }
      else
      {
         Debug.LogError( "System Already Initialized : "+GetType().Name);
      }
   }
   
   public void Dispose()
   {
      OnDispose();
   }
   
   protected abstract void OnInit();

   protected abstract void OnDispose();

}
