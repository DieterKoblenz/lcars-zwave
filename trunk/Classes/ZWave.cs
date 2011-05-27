using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenZWaveDotNet;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace LCARSHome
{
    class ZWave
    {
        // Configuration details
        static internal string zWaveConfigPath = Directory.GetCurrentDirectory();


        static internal UInt32 m_homeId = 0;
        static internal BindingList<Node> m_nodeList = new BindingList<Node>();
        static internal ZWOptions m_options = null;
        static public ZWOptions Options
        {
            get { return m_options; }
        }

        static internal ZWManager m_manager = null;
        static public ZWManager Manager
        {
            get { return m_manager; }
        }

        internal ZWNotification m_notification = null;
        internal Byte m_rightClickNode = 0xff;

        public void ZWave()
        {
            m_options = new ZWOptions();
            m_options.Create(zWaveConfigPath, @"", @"");
            m_options.Lock();
            m_manager = new ZWManager();
            m_manager.Create();
            m_manager.AddDriver(@"\\.\COM3");
        }

        public void NotificationHandler(ZWNotification notification)
        {
            // Handle the notification on a thread that can safely
            // modify the form controls without throwing an exception.
            m_notification = notification;
            NotificationHandler();
            m_notification = null;
        }

        internal void NotificationHandler()
        {
            switch (m_notification.GetType())
            {
                case ZWNotification.Type.ValueAdded:
                    {
                        Node node = GetNode(m_notification.GetHomeId(), m_notification.GetNodeId());
                        if (node != null)
                        {
                            node.AddValue(m_notification.GetValueID());
                        }
                        break;
                    }

                case ZWNotification.Type.ValueRemoved:
                    {
                        Node node = GetNode(m_notification.GetHomeId(), m_notification.GetNodeId());
                        if (node != null)
                        {
                            node.RemoveValue(m_notification.GetValueID());
                        }
                        break;
                    }

                case ZWNotification.Type.ValueChanged:
                    {
                        /*						Console.WriteLine("Value Changed");
                                                ZWValueID v = m_notification.GetValueID();
                                                Console.WriteLine("  Node : " + v.GetNodeId().ToString());
                                                Console.WriteLine("  CC   : " + v.GetCommandClassId().ToString());
                                                Console.WriteLine("  Type : " + v.GetType().ToString());
                                                Console.WriteLine("  Index: " + v.GetIndex().ToString());
                                                Console.WriteLine("  Inst : " + v.GetInstance().ToString());
                                                Console.WriteLine("  Value: " + GetValue(v).ToString());
                                                Console.WriteLine("  Label: " + m_manager.GetValueLabel(v));
                                                Console.WriteLine("  Help : " + m_manager.GetValueHelp(v));
                                                Console.WriteLine("  Units: " + m_manager.GetValueUnits(v));
                        */
                        break;
                    }

                case ZWNotification.Type.Group:
                    {
                        break;
                    }

                case ZWNotification.Type.NodeAdded:
                    {
                        // if this node was in zwcfg*.xml, this is the first node notification
                        // if not, the NodeNew notification should already have been received
                        if (GetNode(m_notification.GetHomeId(), m_notification.GetNodeId()) == null)
                        {
                            Node node = new Node();
                            node.ID = m_notification.GetNodeId();
                            node.HomeID = m_notification.GetHomeId();
                            m_nodeList.Add(node);
                        }
                        break;
                    }

                case ZWNotification.Type.NodeNew:
                    {
                        // Add the new node to our list (and flag as uninitialized)
                        Node node = new Node();
                        node.ID = m_notification.GetNodeId();
                        node.HomeID = m_notification.GetHomeId();
                        m_nodeList.Add(node);
                        break;
                    }

                case ZWNotification.Type.NodeRemoved:
                    {
                        foreach (Node node in m_nodeList)
                        {
                            if (node.ID == m_notification.GetNodeId())
                            {
                                m_nodeList.Remove(node);
                                break;
                            }
                        }
                        break;
                    }

                case ZWNotification.Type.NodeProtocolInfo:
                    {
                        Node node = GetNode(m_notification.GetHomeId(), m_notification.GetNodeId());
                        if (node != null)
                        {
                            node.Label = m_manager.GetNodeType(m_homeId, node.ID);
                        }
                        break;
                    }

                case ZWNotification.Type.NodeNaming:
                    {
                        Node node = GetNode(m_notification.GetHomeId(), m_notification.GetNodeId());
                        if (node != null)
                        {
                            node.Manufacturer = m_manager.GetNodeManufacturerName(m_homeId, node.ID);
                            node.Product = m_manager.GetNodeProductName(m_homeId, node.ID);
                            node.Location = m_manager.GetNodeLocation(m_homeId, node.ID);
                            node.Name = m_manager.GetNodeName(m_homeId, node.ID);
                        }
                        break;
                    }

                case ZWNotification.Type.NodeEvent:
                    {
                        break;
                    }

                case ZWNotification.Type.PollingDisabled:
                    {
                        Console.WriteLine("Polling disabled notification");
                        break;
                    }

                case ZWNotification.Type.PollingEnabled:
                    {
                        Console.WriteLine("Polling enabled notification");
                        break;
                    }

                case ZWNotification.Type.DriverReady:
                    {
                        m_homeId = m_notification.GetHomeId();
                        //toolStripStatusLabel1.Text = "Initializing...driver with Home ID 0x" + m_homeId.ToString("X8") + " is ready.";
                        break;
                    }
                case ZWNotification.Type.NodeQueriesComplete:
                    {
                        // as an example, enable query of BASIC info (CommandClass = 0x20)
                        Node node = GetNode(m_notification.GetHomeId(), m_notification.GetNodeId());
                        if (node != null)
                        {
                            foreach (ZWValueID vid in node.Values)
                            {
                                //								if (vid.GetCommandClassId() == 0x84)	// remove this "if" to poll all values
                                m_manager.EnablePoll(vid);
                            }
                        }
                        //toolStripStatusLabel1.Text = "Initializing...node " + node.ID + " query complete.";
                        break;
                    }
                case ZWNotification.Type.AllNodesQueried:
                    {
                        //toolStripStatusLabel1.Text = "Ready:  All nodes queried.";
                        break;
                    }
                case ZWNotification.Type.AwakeNodesQueried:
                    {
                      //  toolStripStatusLabel1.Text = "Ready:  Awake nodes queried (but not some sleeping nodes).";
                        break;
                    }
            }

            //NodeGridView.Refresh();
           // NodeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
           // NodeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        internal Node GetNode(UInt32 homeId, Byte nodeId)
        {
            foreach (Node node in m_nodeList)
            {
                if ((node.ID == nodeId) && (node.HomeID == homeId))
                {
                    return node;
                }
            }

            return null;
        }

        internal void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_manager.WriteConfig(m_homeId);
        }

        internal void NodeGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.Button == System.Windows.Forms.MouseButtons.Right))
            {
                // Highlight the clicked row
                //NodeGridView.Rows[e.RowIndex].Selected = true;

                // Store the index of the selected node
               // m_rightClickNode = Convert.ToByte(NodeGridView.Rows[e.RowIndex].Cells["Node"].Value);
            }
        }

        internal void PowerOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_manager.SetNodeOn(m_homeId, m_rightClickNode);
        }

        internal void PowerOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_manager.SetNodeOff(m_homeId, m_rightClickNode);
        }
        

        string GetValue(ZWValueID v)
        {
            switch (v.GetType())
            {
                case ZWValueID.ValueType.Bool:
                    bool r1;
                    m_manager.GetValueAsBool(v, out r1);
                    return r1.ToString();
                case ZWValueID.ValueType.Byte:
                    byte r2;
                    m_manager.GetValueAsByte(v, out r2);
                    return r2.ToString();
                case ZWValueID.ValueType.Decimal:
                    decimal r3;
                    m_manager.GetValueAsDecimal(v, out r3);
                    return r3.ToString();
                case ZWValueID.ValueType.Int:
                    Int32 r4;
                    m_manager.GetValueAsInt(v, out r4);
                    return r4.ToString();
                case ZWValueID.ValueType.List:
                    string[] r5;
                    m_manager.GetValueListItems(v, out r5);
                    string r6 = "";
                    foreach (string s in r5)
                    {
                        r6 += s;
                        r6 += "/";
                    }
                    return r6;
                case ZWValueID.ValueType.Schedule:
                    return "Schedule";
                case ZWValueID.ValueType.Short:
                    short r7;
                    m_manager.GetValueAsShort(v, out r7);
                    return r7.ToString();
                case ZWValueID.ValueType.String:
                    string r8;
                    m_manager.GetValueAsString(v, out r8);
                    return r8;
                default:
                    return "";
            }
        }
    }
}
