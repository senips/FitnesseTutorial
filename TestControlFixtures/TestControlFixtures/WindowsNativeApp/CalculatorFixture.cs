using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestControl.Net;
using TestControl.Net.Interfaces;
using TestControl.Net.Locators;
using TestControl.Net.StdControls;



namespace TestControlFixtures.WindowsNativeApp
{
    public class CalculatorFixture
    {
        public CalculatorFixture()
        {
            //create all digit locators
            CreateDigitButtons();
            //create result display
            var locator = new ControlLocatorDefRepo("result");
            locator.FindUsing("app");
            locator.FindByAutomationId("403");

            //locator for =
            CreateLocatorByName("=");
            
        }

        public void EnterValue(String aValue)
        {
            var button = new ButtonControl();
            foreach (char ch in aValue)
            {
                button.SystemUnderTestFromRepo(ch.ToString());
                button.Click();
                button.Wait(0, 50);
            }
        }        

        private void CreateDigitButtons()
        {
            for (int i = 0; i < 10; i++)
            {
                CreateLocatorByName(i.ToString());
            }             
        }

        private void CreateLocatorByName(String name)
        {
            var locator = new ControlLocatorDefRepo(name);
            locator.FindUsing("app");
            locator.FindByName(name);
        }

        public void Operation(String opr)
        {
            CreateLocatorByName(opr);
            var button = new ButtonControl();            
            button.SystemUnderTestFromRepo(opr);
            button.Wait(0, 50);
            button.Click();
        }

        public String Result
        {
            get
            {
               
                var button = new ButtonControl();
                button.SystemUnderTestFromRepo("=");
                button.Wait(0, 20);
                button.Click();

                var txt = new TextBoxControl();
                txt.SystemUnderTestFromRepo("result");
                return txt.Text.Trim();
            }
        } 
    }
}
