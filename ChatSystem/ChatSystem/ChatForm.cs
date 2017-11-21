using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSystem
{
    public partial class ChatForm : Form
    {
        public Controller con = new Controller();
        LoginForm logfrm;
        public string currentUser;
        BindingSource roomBinding = new BindingSource();

        public string selectRoom = "";

        public ChatForm()
        {
            InitializeComponent();
            CreateData();
            logfrm = new LoginForm(this);
            logfrm.Show();

            roomBinding.DataSource = con.rooms;
            ListBoxServers.DataSource = roomBinding;

            ListBoxServers.DisplayMember = "Display";

        }

        public void CreateData()
        {
            con.rooms.Add(new Room { name = "Generel" });
            con.rooms.Add(new Room { name = "Gemme" });
            con.rooms.Add(new Room { name = "LOL" });
            con.rooms.Add(new Room { name = "ASDF" });
            con.rooms.Add(new Room { name = "Programmer" });

            con.users.Add(new User { id = 1, name = "John", password = "pas" });
            con.users.Add(new User { id = 2, name = "Lukas", password = "pas" });
            con.users.Add(new User { id = 3, name = "Jonas", password = "pas" });
            con.users.Add(new User { id = 2, name = "Kevin", password = "pas" });
            con.users.Add(new User { id = 2, name = "Danny", password = "pas" });
            con.users.Add(new User { id = 2, name = "Jannik", password = "pas" });



        }

        

        public void Login(string username, string password)
        {
            int wrongcounter2 = con.UserListCount();
            int wrongcounter = 1;
            foreach (User user in con.users)
            {
                if (username == user.name && password == user.password)
                {
                    currentUser = username;
                    //MessageBox.Show(currentUser);
                    logfrm.Hide();
                    this.Opacity = 1.0;

                    txtUserName.Text = currentUser;

                } else if (wrongcounter == wrongcounter2 )
                {
                    MessageBox.Show("Wong");
                }
                else
                {
                    wrongcounter++;
                }
                
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtUserMessage.Text != "" && selectRoom != "")
            {
                con.messages.Add(new Message { username = currentUser, message = txtUserMessage.Text, roomName = selectRoom, time = DateTime.Now.ToString("HH:mm") });
                UpdateServerChat();
                txtUserMessage.Clear();
            } else
            {
                txtServerChat.Text = "You need to chose a server \r\n <-------";
            }
        }

        public void UpdateServerChat()
        {
            txtServerChat.Clear();
            foreach (Message message in con.messages.Where(x => x.roomName == selectRoom))
            {
                txtServerChat.AppendText(string.Format("{0} : {1} : {2} \r\n", message.username, message.message, message.time));
            }
        }

        private void btnChoseServer_Click(object sender, EventArgs e)
        {
            Room selectedRoom = (Room)ListBoxServers.SelectedItem;

            selectRoom = string.Format(selectedRoom.name);

            //MessageBox.Show(selectRoom);

            txtServerChat.Clear();
            foreach (Message message in con.messages.Where(x => x.roomName == selectRoom))
            {
                txtServerChat.AppendText(string.Format("{0} : {1} : {2} \r\n", message.username, message.message, message.time));
            }
        }

        private void SelectItemListBox(object sender, EventArgs e)
        {
            Room selectedRoom = (Room)ListBoxServers.SelectedItem;

            selectRoom = string.Format(selectedRoom.name);

            //MessageBox.Show(selectRoom);

            txtServerChat.Clear();
            foreach (Message message in con.messages.Where(x => x.roomName == selectRoom))
            {
                txtServerChat.AppendText(string.Format("{0} : {1} : {2} \r\n", message.username, message.message, message.time));
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logfrm.Show();
            this.Opacity = 0.0;
            
        }
    }
}
