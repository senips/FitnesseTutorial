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



namespace TestControlFixtures.WinForm
{
    public class ButtonFixture : BaseFixture
    {
        
        public ButtonFixture()
        {
            FixtureUnderTest = new TextBoxFixture();
        }

        public void ClickTheButton()
        {
            GetButton().Click();
        }        

        private ButtonControl GetButton()
        {
            var button = new ButtonControl();
            button.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow(APPLICATION_CAPTION),
                                                () => new FindByAutomationId("buttonOk")
                    ));
            return button;
        }

    

    }
}
