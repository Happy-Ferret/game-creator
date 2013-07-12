﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameCreator.Framework.Gml
{
    public class GreaterThan : BinaryExpression
    {
        public GreaterThan(Expression e1, Expression e2, int line, int col) : base(e1, e2, line, col) { }

        public override ExpressionKind Kind
        {
            get { return ExpressionKind.GreaterThan; }
        }

        public override Expression Reduce()
        {
            return Fold(Left, Right, (v1, v2) => v1 > v2);
        }

        public override string Operator
        {
            get { return ">"; }
        }
    }
}
