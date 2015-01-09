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
            
        }

        public void ClickTheButton()
        {
            GetButton().Click();
        }        

        private ButtonControl GetButton()
        {
            var button = new ButtonControl();
            button.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow(""),
                                                () => new FindByAutomationId("buttonOk")
                    ));
            return button;
        }

    

    }
}
