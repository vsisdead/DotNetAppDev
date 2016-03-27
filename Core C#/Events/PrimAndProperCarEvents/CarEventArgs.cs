﻿using System;

namespace PrimAndProperCarEvents
{
   public class CarEventArgs : EventArgs
   {
      public readonly string msg;
      public CarEventArgs(string message)
      {
         msg = message;
      }
   }

}
