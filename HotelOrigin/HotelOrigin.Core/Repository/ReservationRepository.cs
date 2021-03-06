﻿using HotelOrigin.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core.Repository
{
    public class ReservationRepository
    {
        public static ObservableCollection<Reservation> reservations = new ObservableCollection<Reservation>();

        public static Reservation Create()
        {
            Reservation reservation = new Reservation();

            reservations.Add(reservation);
            return reservation;
        }
        public static void Add(Reservation reservation)
        {
            reservations.Add(reservation);
        }
        public static Reservation GetById(Object customer)
        {
            return reservations.FirstOrDefault(r => r.Customer == customer);
        }
        public static ObservableCollection<Reservation> GetAll()
        {
            return reservations;
        }
        public static void Update(Reservation reservation, Customer customer, Room room, DateTime checkInDate, DateTime checkOutDate)
        {
            reservation.Customer = customer;
            reservation.Room = room;
            reservation.CheckInDate = checkInDate;
            reservation.CheckOutDate = checkOutDate;
        }
        public static void Delete (Reservation reservation)
        {
            reservations.Remove(reservation);
        }


    }
}
