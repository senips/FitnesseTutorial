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
            ToolBar1.Click(toolbarButtonCaption.Split('/'));
        }

        public void SelectMenuItem(String caption)
        {

            MenuStrip1.Click(caption.Split('/'));
        }


        public MenuStrip MenuStrip1
        {
            get
            {
                var menu = new MenuStrip();
                menu.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                    () => new FindWindow(APPLICATION_CAPTION),
                                                    () => new FindByAutomationId("menuStrip1")
                        ));
                return menu;
            }
        }

        public MenuStrip ToolBar1
        {
            get
            {
                var menu = new MenuStrip();
                menu.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                                    () => new FindWindow(APPLICATION_CAPTION),
                                                    () => new FindByAutomationId("toolStrip1")
                        ));
                return menu;
            }
        }

    }
}
