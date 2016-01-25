using System;
using HotelOrigin.Core.Domain;
using HotelOrigin.Core.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for ReservationListWindow.xaml
    /// </summary>
    public partial class ReservationListWindow : Window
    {
        public ReservationListWindow()
        {
            InitializeComponent();
            
            dataGrid.ItemsSource = ReservationRepository.GetAll();
        }

        private void buttonAddReservation_Click(object sender, RoutedEventArgs e)
        {
            int i = dataGrid.Items.Count;
            Reservation reservation = new Reservation
            {
                Customer = new Customer
                {
                    Id = i,
                    FirstName = "Greg" + " " + i,
                    LastName = "McIntyre",
                    Email = "nocolong@gmail.com",
                    TelephoneNumber = "6198888888"

                },
               
                Room = new Room
                {
                    RoomNumber = 123,
                    NumberOfBeds = 2,
                    HasTv = true
                },
                CheckInDate = DateTime.Parse("1/22/2015"),
                CheckOutDate = DateTime.Parse("1/23/2016")

            };
            ReservationRepository.Add(reservation);
        }
    }
}
