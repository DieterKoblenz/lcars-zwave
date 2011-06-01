using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlThink.ZWave;

namespace LCARSHome
{
    class Zwave
    {
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
    }
}
