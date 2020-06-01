using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qb30Setting
{
    public partial class Form1 : Form
    {
        private const string REG_ROOT_PATH = "SOFTWARE\\WOW6432Node\\OLE";
        private RegistryKey reg_root_key_;
        private static string[] arr_qr_function_enable_disable = new string[] { "ComPort","ScanMode" };
        private static string[] arr_qr_setting_default = new string[] { "COM3", "4" };
        public Form1()
        {
            InitializeComponent();
            reg_root_key_ = Registry.LocalMachine.OpenSubKey(REG_ROOT_PATH, true);
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (reg_root_key_ != null)
            {
                //Comport
                object _data = reg_root_key_.GetValue("ComPort");
                if (_data != null)
                {
                    txtComPort.Text = (string)_data;
                }
                //Scan Mode
                _data = reg_root_key_.GetValue("ScanMode");
                if (_data != null)
                {
                    int iMode;
                    Int32.TryParse((string)_data, out iMode);
                    cbScanMode.SelectedIndex = iMode;
                }
                //Enable/Disable Func
                for (int i = 0; i < 1; i++)
                {
                    _data = reg_root_key_.GetValue(arr_qr_function_enable_disable[i]);
                    if (_data != null)
                    {
                        int iMode;
                        Int32.TryParse((string)_data, out iMode);

                        //cbScanMode.SelectedIndex = iMode;
                    }
                    else
                    {
                        //Create Name
                        reg_root_key_.CreateSubKey(arr_qr_function_enable_disable[i]);
                        reg_root_key_.SetValue(arr_qr_function_enable_disable[i],arr_qr_setting_default[i]);
                    }
                }


            }
        }
    }
    public enum QR_SCAN_MODE
    {
        CONTINUOUS_READING_MODEA = 0,
        CONTINUOUS_READING_MODEB,
        DIRECT_TRIGGER_MODE,
        INDIRECT_TRIGGER_MODE,
        DIRECT_SOFTWARE_TRIGGER_MODE,
        INDIRECT_SOFTWARE_TRIGGER_MODE,
        AUTO_SENSE_MODE
    }
}
