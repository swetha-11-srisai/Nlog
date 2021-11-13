using System;
using System.Collections.Generic;
using System.Text;

namespace NLogProject
{
    public class AddNumbers
    {
            private readonly NLog nLog = new NLog();
            public int Sum(int firstNumber, int secondNumber)
            {
                ////Checking values equal to 0
                if (firstNumber == 0 || secondNumber == 0)
                {
                    nLog.LogDebug("Debug Successfull : Sum()");
                    nLog.LogError("Expecting null values");
                    nLog.LogWarn("secondNumber or secondNumber should not equal to 0");
                }
                int result = secondNumber + secondNumber;
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogInfo("Sum Method passed, Result" + result);
                return result;
            }
     }
    
}
