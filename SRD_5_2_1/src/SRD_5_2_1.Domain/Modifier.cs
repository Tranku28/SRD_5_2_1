using System;
using System.Collections.Generic;
using System.Text;

namespace SRD_5_2_1.Domain
{
    public readonly struct Modifier
    {
        public int Value { get; }

        public Modifier(AbilityScore score) 
        {
            Value = CalcModifier(score.Value); 
        }

        private int CalcModifier(int value)
        {
            return (value - 10) / 2;
        }
    }
}
