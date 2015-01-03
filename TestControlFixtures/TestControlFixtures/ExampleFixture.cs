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
    public class ExampleFixture
    {
        private IApplicationUnderTest _testApp;

        public ExampleFixture()
        {
            _testApp = new WinFormTestApplication(CurrentPath, @"WinFormAutomationDemo.Exe");
        }

        public void LaunchApplication()
        {
            _testApp.Terminate();
            _testApp.ShowDesktop();
            _testApp.Run();
        }

        public String CurrentPath
        {
            get
            {
                return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";
            }
        }

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

        public void ClickTheButton()
        {
            GetButton().Click();
        }

        private TextBoxControl GetTextBoxOne()
        {
            var textBox = new TextBoxControl();
            textBox.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                ()=> new Wait(300),
                                                () => new FindWindow("Demo Form"),
                                                () => new FindByAutomationId("textBox1")
                    ));
            return textBox;
        }



        private TextBoxControl GetTextBoxTwo()
        {
            var textBox = new TextBoxControl();
            textBox.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow("Demo Form"),
                                                () => new FindByAutomationId("textBox2")
                    ));
            return textBox;
        }

        private ButtonControl GetButton()
        {
            var button = new ButtonControl();
            button.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow("Demo Form"),
                                                () => new FindByAutomationId("buttonOk")
                    ));
            return button;
        }


        public void SelectToolBarButton(String buttonName)
        {
            ClickAccessibleObject("toolStrip1", buttonName);
        }

        public void SelectMenuItem(String caption)
        {
            ClickAccessibleObject("menuStrip1", caption);
        }


        public void ClickAccessibleObject(String automationId, String caption)
        {
            var button = new ButtonControl();
            button.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow("Demo Form"),
                                                () => new FindByAutomationId(automationId),
                                                () => new ClickNonWindowControlByCaption(new[]{"File"}),
                                                 () => new ClickNonWindowControlByCaption(new[]{"New"}),
                                                  () => new ClickNonWindowControlByCaption(new[]{"CSharp File"})
                    ));
           
        }

    }
}
