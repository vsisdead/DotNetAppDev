﻿using System;

namespace Visitor
{
   public class VacationVisitor : IVisitor
   {
      public void Visit(IElement element)
      {
         var employee = element as Employee;
         if (employee != null)
         {
            Console.WriteLine("{0} {1}'s new vacation days: {2}",
               employee.GetType().Name,
               employee.Name,
               employee.VacationDays);
         }
      }
   }
}