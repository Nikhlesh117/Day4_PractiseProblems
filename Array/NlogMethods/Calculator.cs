using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogMethods
{
    public class Calculator
    {
        private readonly Nlog nLog = new Nlog();
        public int Add(int x, int y)
        {
            int result = x + y;
            nLog.LogDebug($"Add: {x} + {y} = {result}");
            return result;
        }

        public int Subtract(int x, int y)
        {
            int result = x - y;
            nLog.LogDebug($"Subtract: {x} - {y} = {result}");
            return result;
        }

        public int Multiply(int x, int y)
        {
            int result = x * y;
            nLog.LogInfo($"Multiply: {x} * {y} = {result}");
            return result;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                nLog.LogError("Divide by zero error");
            }

            int result = x / y;
            nLog.LogWarning($"Divide: {x} / {y} = {result}");
            return result;
        }
    }
}
