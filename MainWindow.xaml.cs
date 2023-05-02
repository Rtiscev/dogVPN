using dogVPN;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
namespace f2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VPNConnector connector;
        public MainWindow()
        {
            InitializeComponent();
            //VPNConnector connector = new VPNConnector("gr4.vpnjantit.com", "eee", "abc-vpnjantit.com", "ddd", Protocol.IKEv2);
        }

        private void connect(object sender, RoutedEventArgs e)
        {
            connector = new VPNConnector(serverName.Text, "uhh", userName.Text, password.Text, Protocol.PPTP);
            connector.CreateOrUpdate();
            connector.TryConnect();
        }

        private void disconnect(object sender, RoutedEventArgs e)
        {
            if (connector != null)
            {
                connector.TryDisconnect();
            }
        }
    }

}
