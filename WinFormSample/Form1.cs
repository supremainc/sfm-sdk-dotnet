using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suprema.SFM_SDK_NET;

namespace WinFormSample
{
    public partial class Form1 : Form
    {
        public SFM_SDK_NET sdk = new SFM_SDK_NET();
        public UF_RET_CODE ret = new UF_RET_CODE();
        public EnrollCallback enrollCallback;
        public IdentifyCallback identifyCallback;
        public VerifyCallback verifyCallback;
        public String m_ComPort;
        public int m_Baudrate = 115200;
        public bool m_AsciiMode = false;
        public bool m_bConnected = false;
        public uint m_userID = 0;
                               
        public Form1()
        {
            InitializeComponent();
            tb_comPort.Text = "COM8";
            tb_baudrate.Text = String.Format("{0}", m_Baudrate);
            tb_userID.Text = String.Format("{0}", m_userID);

            enrollCallback = new EnrollCallback(EnrollCallbackFunction);
            identifyCallback = new IdentifyCallback(ScanCallback);
            verifyCallback = new VerifyCallback(ScanCallback);
            
        }
         
        public void EnrollCallbackFunction(byte errCode, UF_ENROLL_MODE enrollMode, int numOfSuccess)
        {
            if (errCode == (byte)UF_PROTOCOL_RET_CODE.UF_PROTO_RET_SCAN_SUCCESS)
            {
                Message("Scan Success");
            }
            else if(errCode == (byte)UF_PROTOCOL_RET_CODE.UF_PROTO_RET_SUCCESS && numOfSuccess == 1)
            {
                Message("Place your finger on the sensor again!");
            }
            else
            {
                Message(String.Format("Error : {0:X}", errCode));
            }            
        }
        void ScanCallback(byte errCode)
        {
            if(errCode == (byte)UF_PROTOCOL_RET_CODE.UF_PROTO_RET_SCAN_SUCCESS)
            {
                Message("Scan Success");                
            }
            else
            {
                Message(String.Format("Error : {0:X}", errCode));
            }            
        }

        private void Message(String message)
        {
            tb_message.Text = message;
            Application.DoEvents();
        }

        private void Connect()
        {
            if (m_bConnected == true)
            {
                Disconnect();
            }

            m_ComPort = tb_comPort.Text;
            m_Baudrate = Convert.ToInt32(tb_baudrate.Text);
            m_AsciiMode = false; //defualt

            ret = sdk.UF_InitCommPort(m_ComPort, m_Baudrate, m_AsciiMode);
            
            if (ret != UF_RET_CODE.UF_RET_SUCCESS)
            {
                Message(String.Format("Error : {0} , Failed to initialize COM Port", ret.ToString()));
                return;
            }

            uint param = 0;
            uint size = 0;
            byte flag = 0;
            ret = sdk.UF_Command((byte)UF_COMMAND.UF_COM_SS, ref param, ref size, ref flag);

            if(ret != UF_RET_CODE.UF_RET_SUCCESS)
            {
                Message(String.Format("Error : {0}, Failed to connect", ret.ToString()));
                return;
            }


            sdk.UF_InitSysParameter();
            sdk.UF_SetEnrollCallback(enrollCallback);
            sdk.UF_SetIdentifyCallback(identifyCallback);
            sdk.UF_SetVerifyCallback(verifyCallback);
            

            Message("Connected");

            m_bConnected = true;

        }

        private void Disconnect()
        {
            if(m_bConnected)
            {
                ret = sdk.UF_CloseCommPort();
                if (ret != UF_RET_CODE.UF_RET_SUCCESS)
                {
                    Message(String.Format("Error : {0} , Failed to close COM port", ret.ToString()));
                }
                Message("Disconnected");
                m_bConnected = false;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            if (!m_bConnected)
            {
                Message("Module is not connected");
                return;
            }

            if (tb_userID.Text == "")
                tb_userID.Text = "0";

            m_userID = Convert.ToUInt32(tb_userID.Text);

            uint enrolledID = 0;
            uint imageQuality = 0;

            Message("Place your finger on the sensor");
            ret = sdk.UF_Enroll(m_userID, m_userID == 0 ? UF_ENROLL_OPTION.UF_ENROLL_AUTO_ID : UF_ENROLL_OPTION.UF_ENROLL_NONE, ref enrolledID, ref imageQuality);
            
            if(ret == UF_RET_CODE.UF_RET_SUCCESS)
            {
                Message(String.Format("User {0} has been enrolled ({1})", enrolledID, imageQuality));
                tb_userID.Text = String.Format("{0}", enrolledID);
                return;
            }

            Message(String.Format("Error : {0} , Failed to enroll", ret.ToString()));
      
        }

        private void btn_identify_Click(object sender, EventArgs e)
        {
            if (!m_bConnected)
            {
                Message("Module is not connected");
                return;
            }

            uint userID = 0;
            byte subID = 0;

            Message("Place your finger on the sensor");
            ret = sdk.UF_Identify(ref userID, ref subID);

            if (ret == UF_RET_CODE.UF_RET_SUCCESS)
            {
                Message(String.Format("Identify Success, User ID : {0} ({1})", userID, subID));
                return;
            }

            Message(String.Format("Error : {0} , Failed to identify", ret.ToString()));
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (!m_bConnected)
            {
                Message("Module is not connected");
                return;
            }

            uint userID = Convert.ToUInt32(tb_userID.Text);
            byte subID = 0;

            if (userID == 0)
            {
                Message("User ID is not entered");
                return;
            }
            
            Message("Place your finger on the sensor");
            ret = sdk.UF_Verify(userID, ref subID);
            
            if (ret == UF_RET_CODE.UF_RET_SUCCESS)
            {
                Message(String.Format("Verify Success, User ID : {0} ({1})", userID, subID));
                return;
            }

            Message(String.Format("Error : {0} , Failed to identify", ret.ToString()));
        }

        private void btn_deleteTemplate_Click(object sender, EventArgs e)
        {
            if (!m_bConnected)
            {
                Message("Module is not connected");
                return;
            }
          
            uint userID = Convert.ToUInt32(tb_userID.Text);

            if (userID == 0)
            {
                Message("User ID is not entered");
                return;
            }

            ret = sdk.UF_Delete(userID);

            if (ret == UF_RET_CODE.UF_RET_SUCCESS)
            {
                Message(String.Format("Delete Success"));
                return;
            }

            Message(String.Format("Error : {0} , Failed to delete the template", ret.ToString()));
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            if (!m_bConnected)
            {
                Message("Module is not connected");
                return;
            }

            ret = sdk.UF_DeleteAll();

            if (ret == UF_RET_CODE.UF_RET_SUCCESS)
            {
                Message(String.Format("All templates has been deleted"));
                return;
            }

            Message(String.Format("Error : {0} , Failed to delete all templates", ret.ToString()));
        }
    }
}
