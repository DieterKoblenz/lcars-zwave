using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlThink.ZWave;
using OpenZWaveDotNet;

namespace LCARSHome
{
    class Zwave
    {
        public static bool m_ready = false;
        public static List<Node> _nodes = new List<Node>();
        public static void PowerOn(byte NodeID)
        {
            if (Properties.Settings.Default.ControllerType == "ControlThink")
            {
                ZWaveController controller = new ZWaveController();
                try
                {
                    controller.Connect();
                    controller.Devices.GetByNodeID(NodeID).PowerOn();
                }
                catch
                {
                }
                finally
                {
                    controller.Disconnect();
                }
            }
            else if (Properties.Settings.Default.ControllerType == "OpenZWave")
            {
                //MainForm.Manager.SetNodeLevel(Properties.Settings.Default.HomeID, NodeID, 255);
                MainForm.Manager.SetNodeOn(Properties.Settings.Default.HomeID, NodeID);
            }
            else
            {
                throw new NotSupportedException("Controller Type is Not Supported.");
            }
        }

        internal static bool PoweredOn(byte NodeID)
        {
            ZWaveController controller = new ZWaveController();
            if (Properties.Settings.Default.ControllerType == "ControlThink")
            {
                try
                {
                    controller.Connect();
                    byte Level = controller.Devices.GetByNodeID(NodeID).Level;
                    switch (Level)
                    {
                        case 0:
                            return false;
                        case 255:
                            return true;
                        default:
                            return true;
                    }
                }
                finally
                {
                    MainForm.Manager.SetNodeLevel(Properties.Settings.Default.HomeID, NodeID, 0);
                }
            }
            else if (Properties.Settings.Default.ControllerType == "OpenZWave")
            {
                bool ret = false;
                //if (_nodes.Find(item => item.ID == NodeID). )
                //    ret=true;
                string result = "";
                try
                {
                    MainForm.Manager.GetValueAsString(_nodes.Find(item => item.ID == NodeID).Value, out result);
                }
                catch { }
                Console.WriteLine("IsPoweredOnResult: " + result);
                if (result == "true" || result == "255")
                    ret = true;
                else
                {
                    try
                    {
                        MainForm.Manager.GetValueAsBool(_nodes.Find(item => item.ID == NodeID).Value, out ret);
                    }
                    catch { }
                }
                return ret;
            }
            else
            {
                throw new NotSupportedException("Controller Type is Not Supported.");
            }
        }

        internal static void PowerOff(byte NodeID)
        {
            ZWaveController controller = new ZWaveController();
            if (Properties.Settings.Default.ControllerType == "ControlThink")
            {
                try
                {
                    controller.Connect();
                    controller.Devices.GetByNodeID(NodeID).PowerOff();
                }
                finally
                {
                    controller.Disconnect();
                }
            }
            else if (Properties.Settings.Default.ControllerType == "OpenZWave")
            {
                //MainForm.Manager.SetNodeLevel(Properties.Settings.Default.HomeID, NodeID, 0);
                MainForm.Manager.SetNodeOff(Properties.Settings.Default.HomeID, NodeID);
            }
            else
            {
                throw new NotSupportedException("Controller Type is Not Supported.");
            }
        }

        internal static string Diagnostic(byte NodeID)
        {
            ZWaveController controller = new ZWaveController();
            string result;
            if (Properties.Settings.Default.ControllerType == "ControlThink")
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    controller.Connect();
                    sb.Append("Node ID: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).NodeID.ToString()); }
                    catch { sb.Append("ERROR"); }
                    
                    sb.Append("|Name: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).Name.ToString()); }
                    catch { sb.Append("ERROR"); }
                    
                    sb.Append("|Type: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).GetType().ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|Groups: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).Groups.Count.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|PollEnabled: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).PollEnabled.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|PollInterval: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).PollInterval.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|Security: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).Security.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|Tag: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).Tag.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|Scenes: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).Scenes.Count.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|Level: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).Level.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|AllOffEnabled: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).AllOffEnabled.ToString()); }
                    catch { sb.Append("ERROR"); }

                    sb.Append("|AllOnEnabled: ");
                    try { sb.Append(controller.Devices.GetByNodeID(NodeID).AllOnEnabled.ToString()); }
                    catch { sb.Append("ERROR"); }

                    result = sb.ToString();
                    return result;
                }
                finally
                {
                    controller.Disconnect();
                }
            }
            else if (Properties.Settings.Default.ControllerType == "OpenZWave")
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotSupportedException("Controller Type is Not Supported.");
            }
        }

        internal static void NotificationHandler(ZWNotification notification)
        {
            switch (notification.GetType())
            {
                case ZWNotification.Type.AwakeNodesQueried:
                    {
                        Console.WriteLine(Environment.NewLine + notification.GetType().ToString() + Environment.NewLine);
                        m_ready = true;
                        Program._MainForm.engineeringScreen1.Invalidate();
                        Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses();
                        break;
                    }
                default:
                    {
                        switch (m_ready)
                        {
                            case true:
                                {
                                    Console.WriteLine(notification.GetType().ToString());
                                    string result;
                                    switch (notification.GetType())
                                    {
                                        case ZWNotification.Type.ValueChanged:
                                            {
                                                foreach (Node n in _nodes)
                                                {
                                                    if (n.ID == notification.GetNodeId())
                                                    {
                                                        n.Value = notification.GetValueID();
                                                    }
                                                }
                                                Console.WriteLine(" Node ID: ");
                                                Console.WriteLine(notification.GetNodeId().ToString());
                                                Console.WriteLine(" Byte: ");
                                                Console.WriteLine(notification.GetByte().ToString());
                                                Console.WriteLine(" Value: ");
                                                MainForm.Manager.GetValueAsString(notification.GetValueID(), out result);
                                                Console.WriteLine(result);
                                                Console.WriteLine(Environment.NewLine);
                                                Program._MainForm.engineeringScreen1.Invalidate();
                                                Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses();
                                                break;
                                            }
                                        case ZWNotification.Type.NodeEvent:
                                            {
                                                Console.WriteLine(" Node ID: ");
                                                Console.WriteLine(notification.GetNodeId().ToString());
                                                Console.WriteLine(" Byte: ");
                                                Console.WriteLine(notification.GetByte().ToString());
                                                Console.WriteLine(" Value: ");
                                                MainForm.Manager.GetValueAsString(notification.GetValueID(), out result);
                                                try
                                                {
                                                    Console.WriteLine(result);
                                                }
                                                catch (NullReferenceException e)
                                                {
                                                    Console.WriteLine("NULL");
                                                }
                                                Console.WriteLine(Environment.NewLine);
                                                BusinessLogic.SensorStatusChange(notification.GetNodeId(), notification.GetByte());
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine(Environment.NewLine);
                                                break;
                                            }
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine(notification.GetType().ToString() + ":");
                                    switch (notification.GetType())
                                    {
                                        case ZWNotification.Type.NodeNew:
                                            {
                                                Node n = new Node();
                                                n.HomeID = notification.GetHomeId();
                                                n.ID = notification.GetNodeId();
                                                _nodes.Add(n);
                                                break;
                                            }
                                        case ZWNotification.Type.ValueAdded:
                                            {
                                                foreach (Node n in _nodes)
                                                {
                                                    if (n.ID == notification.GetNodeId())
                                                    {
                                                        n.Value=notification.GetValueID();
                                                    }
                                                }
                                                break;
                                            }

                                    }
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}
