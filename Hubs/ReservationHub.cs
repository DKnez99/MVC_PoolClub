using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using PoolClub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Hubs
{
    public class ReservationHub : Hub
    {
        //public async Task SendReservation(ReservationViewModel reservationViewModel)
        //{
        //    var messageJsonString = JsonConvert.SerializeObject(reservationViewModel);
        //    await Clients.All.SendAsync("ReceiveReservation", messageJsonString);
        //}
    }
}
