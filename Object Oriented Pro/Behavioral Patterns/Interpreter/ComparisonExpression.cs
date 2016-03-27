﻿namespace Interpreter
{
   public abstract class ComparisonExpression : IExpression
   {
      protected IExpression ExpressionA;
      protected IExpression ExpressionB;

      protected ComparisonExpression(IExpression expressionA, IExpression expressionB)
      {
         ExpressionA = expressionA;
         ExpressionB = expressionB;
      }

      public abstract void Interpret(IContext context);
   }
}