﻿using System;
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
    public class TreeViewFixture : BaseFixture
    {
        public TreeViewFixture()
        {
            FixtureUnderTest = new TextBoxFixture();
        }


        private TreeViewControl _treeViewOne;
        public TreeViewControl TreeViewOne
        {
            get
            {
                if (_treeViewOne == null)
                {
                    _treeViewOne = new TreeViewControl();
                    _treeViewOne.SystemUnderTest(new ControlLocatorDef<FindControl>(
                                              () => new FindByAutomationId(APPLICATION_ID, true),
                                              () => new FindByAutomationId("treeView1")
                        ));
                }
                return _treeViewOne;
            }
        }

        public void SelectNode(String byNodeName)
        {
            TreeViewOne.Select(byNodeName);
        }

        public String SelectedNode
        {
            get
            {
                return TreeViewOne.SelectedItem;
            }
        }

        public void DoubleClick()
        {
            TreeViewOne.DblClick();
        }


        public String VisibleNodes
        {
            get
            {
                return TreeViewOne.Values;
            }
        }
 
 
    }
}
