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
    public class MenuAndToolBarFixture : BaseFixture
    {

        public MenuAndToolBarFixture()
        {
            FixtureUnderTest = new TextBoxFixture();
        }

        public void SelectToolBarButton(String toolbarButtonCaption)
        {            
            var button = new ButtonControl();
            button.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow(APPLICATION_CAPTION),
                                                () => new FindByAutomationId("toolStrip1"),
                                                () => new ClickNonWindowControlByCaption(new[] { toolbarButtonCaption })                                               
                    ));
        }

        public void SelectMenuItem(String caption)
        {
 
            var button = new ButtonControl();
            button.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                () => new FindWindow(APPLICATION_CAPTION),
                                                () => new FindByAutomationId("menuStrip1"),
                                                () => new ClickNonWindowControlByCaption(caption.Split('/'))
                    ));
        }


 

    }
}
