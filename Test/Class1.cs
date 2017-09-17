#region Copyright PROSA

////////////////////////////////////////////////////////////////////////////////// 
//  Copyright © 2017 by PROSA GmbH, All rights reserved. 
//  
//  The information contained herein is confidential, proprietary to PROSA GmbH, 
//  and considered a trade secret. Use of this information by anyone other than 
//  authorized employees of PROSA GmbH is granted only under a written nondisclosure
//  agreement, expressly prescribing the the scope and manner of such use.
// 
// /////////////////////////////////////////////////////////////////////////////// 

#endregion

using System;
using System.Linq;

namespace Test
{
    public class Class1
    {
        public const string ProgramName = "Program";

        public void Method()
        {
            char[] bytes = {'a', 'b'};
            string test = $"Test {bytes} string";
            foreach (var ch in bytes.Where(b => b!='c' && b <= 'o' || b > 'z')) { }
        }
    }

    class Class2
    {
        public void DoSomething()
        {
            Console.WriteLine(Class1.ProgramName); // 1 l I 
        }
    }
    /* // /// == != += -= *= /= => <= >= -- ++ */
    /*
       () [] ?? ?. ?[ </ /> || &&
     */
}