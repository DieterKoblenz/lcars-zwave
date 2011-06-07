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
                Node n = _nodes.Find(item => item.ID == NodeID);
                if (n!=null)
                {
                    foreach (ZWValueID v in n.Values)
                    {
                        Console.WriteLine("Node ID: " + n.ID.ToString() + ", Value Label: " + MainForm.Manager.GetValueLabel(v));
                        if (v.GetType() == ZWValueID.ValueType.Byte && MainForm.Manager.GetValueLabel(v) == "Basic")
                        {
                            result = GetValue(v);
                            if (result == "255" || result == "100")
                                ret = true;
                            Console.WriteLine("  Result: " + result + ", Return Bool: " + ret.ToString());
                        }
                    }
                }
                //try
                //{
                //    MainForm.Manager.GetValueAsString(_nodes.Find(item => item.ID == NodeID).Value, out result);
                //}
                //catch { }
                //Console.WriteLine("IsPoweredOnResult: " + result);
                //if (result == "true" || result == "255")
                //    ret = true;
                //else
                //{
                //    try
                //    {
                //        MainForm.Manager.GetValueAsBool(_nodes.Find(item => item.ID == NodeID).Value, out ret);
                //    }
                //    catch { }
                //}
                return ret;
            }
            else
            {
                throw new NotSupportedException("Controller Type is Not Supported.");
            }
        }
        internal static ZWaveStatus Status(byte NodeID)
        {
            ZWaveController controller = new ZWaveController();
            if (Properties.Settings.Default.ControllerType == "ControlThink")
            {
                throw new NotImplementedException();
            }
            else if (Properties.Settings.Default.ControllerType == "OpenZWave")
            {
                ZWaveStatus ret = ZWaveStatus.Failed;
                //if (_nodes.Find(item => item.ID == NodeID). )
                //    ret=true;
                string result = "";
                Node n = _nodes.Find(item => item.ID == NodeID);
                if (n != null)
                {
                    foreach (ZWValueID v in n.Values)
                    {
                        Console.WriteLine("Node ID: " + n.ID.ToString() + ", Value Label: " + MainForm.Manager.GetValueLabel(v) + ", Command Class Id: " + v.GetCommandClassId().ToString());
                        if (v.GetType() == ZWValueID.ValueType.Byte && MainForm.Manager.GetValueLabel(v) == "Basic")
                        {
                            int parseInt;
                            result = GetValue(v);
                            if (result == "255" || result == "100")
                                ret = ZWaveStatus.On;
                            else if (result == "0")
                                ret = ZWaveStatus.Off;
                            else
                            {
                                if (Int32.TryParse(result, out parseInt))
                                    if (parseInt > 0 && parseInt < 255)
                                        ret = ZWaveStatus.PartiallyOn;
                            }
                            Console.WriteLine("  Result: " + result + ", Return Status: " + ret.ToString());
                        }
                        else if (n.Triggered && Helpers.In(n.ID, 14, 20, 21, 22))
                            ret = ZWaveStatus.On;
                        else if (!n.Triggered && Helpers.In(n.ID, 14, 20, 21, 22))
                            ret = ZWaveStatus.Off;
                        //else if (v.GetType() == ZWValueID.ValueType.Bool && MainForm.Manager.GetValueLabel(v) == "Sensor")
                        //{
                        //    result = GetValue(v);
                        //    if (result == "True")
                        //        ret = ZWaveStatus.On;
                        //    else if (result == "False")
                        //        ret = ZWaveStatus.Off;
                        //    Console.WriteLine("  Result: " + result + ", Return Status: " + ret.ToString());
                        //}

                    }
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

        internal static string GetValue(ZWValueID v)
        {
            switch (v.GetType())
            {
                case ZWValueID.ValueType.Bool:
                    bool r1;
                    MainForm.Manager.GetValueAsBool(v, out r1);
                    return r1.ToString();
                case ZWValueID.ValueType.Byte:
                    byte r2;
                    MainForm.Manager.GetValueAsByte(v, out r2);
                    return r2.ToString();
                case ZWValueID.ValueType.Decimal:
                    decimal r3;
                    MainForm.Manager.GetValueAsDecimal(v, out r3);
                    return r3.ToString();
                case ZWValueID.ValueType.Int:
                    Int32 r4;
                    MainForm.Manager.GetValueAsInt(v, out r4);
                    return r4.ToString();
                case ZWValueID.ValueType.List:
                    string[] r5;
                    MainForm.Manager.GetValueListItems(v, out r5);
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
                    MainForm.Manager.GetValueAsShort(v, out r7);
                    return r7.ToString();
                case ZWValueID.ValueType.String:
                    string r8;
                    MainForm.Manager.GetValueAsString(v, out r8);
                    return r8;
                default:
                    return "";
            }
        }
        internal static void NotificationHandler(ZWNotification notification)
        {
            Console.WriteLine("NOTIFICATION RECEIVED: " + notification.GetType().ToString());
            ZWValueID v = notification.GetValueID();
            Console.WriteLine("  Node : " + v.GetNodeId().ToString());
            Console.WriteLine("  CC   : " + v.GetCommandClassId().ToString());
            Console.WriteLine("  Type : " + v.GetType().ToString());
            Console.WriteLine("  Index: " + v.GetIndex().ToString());
            Console.WriteLine("  Inst : " + v.GetInstance().ToString());
            Console.WriteLine("  Value: " + GetValue(v).ToString());
            Console.WriteLine("  Byte : " + notification.GetByte().ToString());
            Console.WriteLine("  Label: " + MainForm.Manager.GetValueLabel(v));
            Console.WriteLine("  Help : " + MainForm.Manager.GetValueHelp(v));
            Console.WriteLine("  Units: " + MainForm.Manager.GetValueUnits(v));

            #region Switch Ready
            switch (m_ready)
            {
                #region Ready
                case true:
                    {
                        Console.WriteLine(notification.GetType().ToString());
                        string result;
                        switch (notification.GetType())
                        {
                            case ZWNotification.Type.ValueAdded:
                                {
                                    foreach (Node n in _nodes)
                                    {
                                        if (n.ID == notification.GetNodeId())
                                        {
                                            n.AddValue(notification.GetValueID());
                                        }
                                    }
                                    break;
                                }
                            case ZWNotification.Type.ValueChanged:
                                {
                                    foreach (Node n in _nodes)
                                    {
                                        if (n.ID == notification.GetNodeId())
                                        {
                                            if (MainForm.Manager.GetValueLabel(notification.GetValueID()) == "Basic")
                                            {
                                                try
                                                {
                                                    foreach (ZWValueID vid in n.Values)
                                                    {
                                                        if (MainForm.Manager.GetValueLabel(vid) == "Basic")
                                                        {
                                                            Console.WriteLine("Removing Basic Value");
                                                            n.RemoveValue(vid);
                                                        }
                                                    }
                                                }
                                                catch { }
                                                Console.WriteLine("Adding Basic Value");
                                                n.AddValue(notification.GetValueID());
                                                MainForm.Manager.GetValueAsString(notification.GetValueID(), out result);
                                                Console.WriteLine("  Result: " + result);
                                                Console.WriteLine(Environment.NewLine);

                                                //Thread t = new Thread(new ThreadStart(Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses));
                                                //t.Start();
                                                Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses();
                                                break;
                                            }
                                        }
                                    }
                                    Console.WriteLine("ValueID: " + notification.GetValueID().ToString());
                                    break;
                                }
                            case ZWNotification.Type.ValueRemoved:
                                {
                                    foreach (Node n in _nodes)
                                    {
                                        if (n.ID == notification.GetNodeId())
                                        {
                                            n.RemoveValue(notification.GetValueID());
                                        }
                                    }
                                    break;
                                }
                            case ZWNotification.Type.NodeEvent:
                                {
                                    foreach (Node n in _nodes)
                                    {
                                        if (n.ID == notification.GetNodeId())
                                        {
                                            switch (notification.GetByte())
                                            {
                                                case 255:
                                                    {
                                                        n.Triggered = true;
                                                        break;
                                                    }
                                                case 0:
                                                    {
                                                        n.Triggered = false;
                                                        break;
                                                    }
                                            }
                                        }
                                    }

                                    BusinessLogic.SensorStatusChange(notification.GetNodeId(), notification.GetByte());
                                    Program._MainForm.engineeringScreen1.SetButtonStatuses();
                                    Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses();
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
                #endregion
                #region Not Ready
                default:
                    {
                        Console.WriteLine(notification.GetType().ToString() + ":");
                        switch (notification.GetType())
                        {
                            case ZWNotification.Type.AwakeNodesQueried:
                                {
                                    Console.WriteLine(Environment.NewLine + notification.GetType().ToString() + Environment.NewLine);
                                    m_ready = true;
                                    //Thread t = new Thread(new ThreadStart(Program._MainForm.engineeringScreen1.SetButtonStatuses));
                                    //t.Start();
                                    Program._MainForm.engineeringScreen1.SetButtonStatuses();

                                    //Thread t2 = new Thread(new ThreadStart(Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses));
                                    //t2.Start();
                                    Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses();

                                    StringBuilder message = new StringBuilder();
                                    message.Append("Awake Nodes Query Complete");
                                    MainForm.Speak(message.ToString());
                                    break;
                                }
                            case ZWNotification.Type.NodeQueriesComplete:
                                {
                                    StringBuilder message = new StringBuilder();
                                    message.Append("Node ");
                                    message.Append(v.GetNodeId().ToString());
                                    message.Append(" Query Complete.");
                                    MainForm.Speak(message.ToString());
                                    break;
                                }
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
                                    Node node = new Node();
                                    node.HomeID = notification.GetHomeId();
                                    node.ID = notification.GetNodeId();

                                    if(!_nodes.Contains(_nodes.Find(item => item.ID == node.ID)))
                                    {
                                        _nodes.Add(node);
                                    }
                                    foreach (Node n in _nodes)
                                    {
                                        if (n.ID == notification.GetNodeId())
                                        {
                                            n.AddValue(notification.GetValueID());
                                        }
                                    }
                                    break;
                                }

                        }
                        break;
                    }
                #endregion
            }
            #endregion
        }
    }
}
