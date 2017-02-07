using System;
using ECAClientFramework;
using LVC.Adapters;
using LVC.Model.test;
using LVC.VcControlDevice;
using LVC.VcSubRoutines;
using System.Xml.Serialization;
using System.IO;

namespace LVC
{
    static class Algorithm
    {
        static VoltVarControllerAdapter vca;
        static VoltVarController PreviousFrame;
        

        static Algorithm()
        {
            string configurationPathName = (@"C:\Users\Chetan\Documents\openECA Projects\Zhijie\LVC20170203\Data\Configurations_test1.xml");
            vca = new VoltVarControllerAdapter();
            vca.ConfigurationPathName = configurationPathName;
            vca.Initialize();
            PreviousFrame = new VoltVarController();
            PreviousFrame = VoltVarController.DeserializeFromXml(configurationPathName);

            /*
             * Testing Files Configurations
             * test1.xml    -   Verify if the controller can RAISE both transformers' taps when voltages on both buses are lower than the limit (VLLIM = 114.5kV)
             * test2.xml    -   Verify if the controller is still able to operate (VLLIM = 114.5kV), when the other transformer's tap has reached the highest tap position (16)
             * test3.xml    -   Verify if the controller can switch ON the capacitor bank when the voltage in Pamplin substation reach the lower limit (Clov = 113.5kV)
             * test4.xml    -   Verify if the controller can switch OFF the capacitor bank when the voltage in Crewe substation reach the higher limit (Chiv = 119.7kV)
            */
        }

        internal class Output
        {
            OutputData OutputData = new OutputData();
            _OutputDataMeta OutputMeta = new _OutputDataMeta();
        }

        public static void UpdateSystemSettings()
        {
            SystemSettings.ConnectionString = @"server=localhost:6190; interface=0.0.0.0";
            SystemSettings.FramesPerSecond = 30;
            SystemSettings.LagTime = 3;
            SystemSettings.LeadTime = 1;
        }

        public static Output Execute(Input inputData, _InputMeta inputMeta)
        {
            Output output = new Output();

            try
            {
                // Output Testing Message in openECA Client MainWindow
                string _message = String.Format("\n=============== MainWindowTempLog_{0:yyyy-MM-dd_hh:mm:ss.fff} ===============\n", DateTime.UtcNow);
                foreach (VcTransformer Transformer in vca.InputFrame.ControlTransformers)
                {
                    _message += String.Format("\n\t- ControlTransformers_{0}_{1}\t| TapV: {2:00} \t VoltsV: {3}", Transformer.DeviceId, Transformer.LtcCtlId, Transformer.TapV, Transformer.VoltsV);
                }

                foreach (VcCapacitorBank CapBank in vca.InputFrame.ControlCapacitorBanks)
                {
                    _message += String.Format("\n\t- ControlCapBanks_{0}\t| CapBkrV: {1} \t VoltsV: {2}  Clov:{3} Chiv:{4}", CapBank.CapBkrId, CapBank.CapBkrV, CapBank.LockvV, CapBank.Clov, CapBank.Chiv);
                }

                MainWindow.WriteMessage(_message);


                // Extract inputData from openECA then Call SubRoutine
                vca.GetData(inputData,inputMeta,PreviousFrame);
                MainWindow.WriteMessage("%%\t" + vca.LogMessage.Replace("|", "\n = "));
                //System.Threading.Thread.Sleep(800);     //Threading: Suspends the current thread for MainWindow Output.

                // Append to tempLog File
                //string tempLogPath = (@"C:\Users\Chetan\Documents\openECA Projects\Zhijie\LVC20170203\CtrlDecisionLog_170206_test1.txt");
                //File.AppendAllText(tempLogPath, _message + "\n%%\t" + vca.LogMessage.Replace("|", "\n = "));

                // Logging control decision to *.xml files
                string logsfolder = (@"C:\Users\Chetan\Documents\openECA Projects\Zhijie\LVC20170203\Logs\\");
                string[] logsfilestr = Directory.GetFiles(logsfolder, "CtrlDecisionLog_*.xml");
                string logsFileName = logsfolder + "CtrlDecisionLog" + String.Format("_{0:000}_{1:yyyyMMdd_hhmmssfff}", (logsfilestr.Length + 1), DateTime.UtcNow) + ".xml";
                vca.SerializeToXml(logsFileName);

                // Store Current vca.InputFrame to previous.InputFrame for the next InputFrame 
                PreviousFrame = vca.InputFrame;
               
                
            }
            catch (Exception ex)
            {
                // Display exceptions to the main window
                MainWindow.WriteError(new InvalidOperationException($"Algorithm exception: {ex.Message}", ex));
            }

            return output;
        }
    }
}
