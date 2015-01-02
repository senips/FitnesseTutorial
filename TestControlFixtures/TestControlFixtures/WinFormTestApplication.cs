using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestControl.Net;
using TestControl.Net.Interfaces;
 

namespace DemoFixtures
{
    public class WinFormTestApplication : ApplicationUnderTest
    {
        public WinFormTestApplication(string workingDir, string exeName) : base(workingDir, exeName)
        {
        }

         
    }
}
