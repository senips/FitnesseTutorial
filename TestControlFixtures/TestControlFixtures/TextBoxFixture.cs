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

namespace TestControlFixtures
{
    public class TextBoxFixture : BaseFixture
    {
        public String TheTextBoxOneValue
        {
            get
            {
                return GetTextBoxOne().Text;
            }
            set
            {
                var textBox = GetTextBoxOne();
                textBox.Text = value;
            }
        }

        public String TheTextBoxTwoValue
        {
            get
            {
                return GetTextBoxTwo().Text;
            }
            set
            {
                var textBox = GetTextBoxTwo();
                textBox.Text = value;
            }
        }


        public TextBoxControl GetTextBoxOne()
        {
            var textBox = new TextBoxControl();
            textBox.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow(APPLICATION_CAPTION),
                                                () => new FindByAutomationId("textBox1")
                    ));
            return textBox;
        }

        public TextBoxControl GetTextBoxTwo()
        {
            var textBox = new TextBoxControl();
            textBox.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow(APPLICATION_CAPTION),
                                                () => new FindByAutomationId("textBox2")
                    ));
            return textBox;
        }
 
    }
}
