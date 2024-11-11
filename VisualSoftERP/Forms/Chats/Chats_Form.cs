using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualSoftERP.Classes;
using VisualSoftERP.Classes.Chats;
using VisualSoftERP.Classes.Utils;
using VisualSoftERP.Models;

namespace VisualSoftERP.Forms.Chats
{
    public partial class Chats_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<ChatsMessages_Model> ChatsMessages = new List<ChatsMessages_Model>();

        public Chats_Form()
        {
            InitializeComponent();
        }


        #region USER INTERACTIONS
        private void Chats_Form_Load(object sender, EventArgs e)
        {
            try
            {
                GetOnlineUsers();
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void Chats_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void timerChats_Tick(object sender, EventArgs e)
        {
            try
            {
                GetOnlineUsers();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void navBarControlOnlineUsers_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm();
            try
            {
                NavBarItemLink link = (NavBarItemLink)e.Link;
                if (link != null)
                {
                    GetChatMessages(Convert.ToInt32(link.Item.Name));
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
        }
        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    SendMessage();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        #endregion USER INTERACTIONS


        #region BUTTONS
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendMessage();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        #endregion BUTTONS


        private void GetOnlineUsers()
        {
            try
            {
                Chats_Class cl = new Chats_Class();
                DataTable dt =  cl.Grid("UsersGetOnlineUsers", cl.parameters);

                if (dt == null || dt.Rows.Count == 0) return;
                else
                {
                    navBarGroupOnlineUsers.Expanded = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (Convert.ToInt32(dr["UsersID"]) != Program_Class.User.UsersID)
                        {
                            navBarItemNoOnlineUsers.Visible = false;
                            NavBarItem item = new NavBarItem();
                            item.Caption = dr["Name"].ToString();
                            item.Name = dr["UsersID"].ToString();
                            navBarGroupOnlineUsers.ItemLinks.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void GetChatMessages(int UserID2)
        {
            try
            {
                Chats_Class cl = new Chats_Class();
                cl.parameters = new Dictionary<string, object>
                {
                    { "UserID1", Program_Class.User.UsersID },
                    { "UserID2", UserID2 }
                };
                DataTable dt = cl.Grid("UsersGetChatMessages", cl.parameters);



            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void SendMessage()
        {
            try
            {
                string mensaje = txtMessage.Text.Trim();




                txtMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }       
    }
}