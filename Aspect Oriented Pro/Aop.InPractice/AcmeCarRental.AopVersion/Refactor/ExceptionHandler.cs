using System;
using AcmeCarRental.AopVersion.Data;

namespace AcmeCarRental.AopVersion.Refactor
{
   public interface IExceptionHandler
   {
      void Wrapper(Action method);
   }

   public class ExceptionHandler : IExceptionHandler
   {
      public void Wrapper(Action method)
      {
         try
         {
            method();
         }
         catch (Exception ex)
         {
            if (!Exceptions.Handle(ex))
               throw;
            throw;
         }
      }
   }
}