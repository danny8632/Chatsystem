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
        //Classes
        public Controller con = new Controller();

        //Forms
        LoginForm logfrm;

        //BindingSources
        BindingSource roomBinding = new BindingSource();

        //Varibles
        public string selectRoom = "";
        public string currentUser;

        public ChatForm()
        {
            InitializeComponent();


            CreateData();

            //Create "new" form(LoginForm)
            //and make it shown
            logfrm = new LoginForm(this);
            logfrm.Show();

            //Creates the items in the listbox(ListBoxServers)
            //By using bindingSource and a Method in the class(Room)
            roomBinding.DataSource = con.rooms;
            ListBoxServers.DataSource = roomBinding;
            ListBoxServers.DisplayMember = "Display";

        }

        public void CreateData()
        {
            
            //Creates new rooms
            con.rooms.Add(new Room { name = "Generel" });
            con.rooms.Add(new Room { name = "Gemme" });
            con.rooms.Add(new Room { name = "LOL" });
            con.rooms.Add(new Room { name = "ASDF" });
            con.rooms.Add(new Room { name = "Programmer" });

            //Creates new Users
            con.users.Add(new User { id = 1, name = "John", password = "pas" });
            con.users.Add(new User { id = 2, name = "Lukas", password = "pas" });
            con.users.Add(new User { id = 3, name = "Jonas", password = "pas" });
            con.users.Add(new User { id = 4, name = "Kevin", password = "pas" });
            con.users.Add(new User { id = 5, name = "Danny", password = "pas" });
            con.users.Add(new User { id = 6, name = "Jannik", password = "pas" });



        }

        
        /// <summary>
        /// Login function, checks with the current data to see if username and password
        /// match with a user.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        public void Login(string username, string password)
        {

            //Definds local veriables, for a "wrong counter" so the code dosent say "wong"
            //Every time it runs the loop
            int wrongcounter2 = con.UserListCount();
            int wrongcounter = 1;

            //Runs a Foreach loop that checks if the username and the password
            //match with the created users
            foreach (User user in con.users)
            {
                if (username == user.name && password == user.password)
                {
                    //Declares the curent user
                    currentUser = username;
                    
                    //Hiding login form and shows the main chat form
                    logfrm.Hide();
                    this.Opacity = 1.0;

                    //Set the txtUserName to the currentusername
                    txtUserName.Text = currentUser;

                } else if (wrongcounter == wrongcounter2 )
                {
                    //Displays a "Wong" message if you type your code wrong
                    MessageBox.Show("Wong");
                }
                else
                {
                    //Adds one to the wrongcounter
                    wrongcounter++;
                }
                
            }
            
        }

        //
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
