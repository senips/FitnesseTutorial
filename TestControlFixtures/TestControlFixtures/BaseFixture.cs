﻿using fitSharp.Machine.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TestControl.Net.Interfaces;

namespace TestControlFixtures
{
    public class BaseFixture : DomainAdapter
    {
        private IApplicationUnderTest _testApp;
        public static String APPLICATION_CAPTION = "Test Control Test Suite  Application";
        public Object FixtureUnderTest;
        public IApplicationUnderTest AppUnderTest
        {
            get
            {
                if (_testApp == null)
                {
                    _testApp = new WinFormTestApplication(CurrentPath, @"WinFormAutomationDemo.Exe");
                   
                }
                return _testApp;
            }
        }

        public String CurrentPath
        {
            get
            {
                return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";
            }
        }

        public void LaunchApplication()
        {
            AppUnderTest.Terminate();
            AppUnderTest.ShowDesktop();
            AppUnderTest.Run();
            AppUnderTest.WaitForCaption(APPLICATION_CAPTION, 3);
        }




        public object SystemUnderTest
        {
            get { return FixtureUnderTest; }
        }
    }
}