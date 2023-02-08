using Microsoft.AspNetCore.SignalR;

namespace SignalR1
{
    public class HydraHub : Hub
    {

        Timer timer;
        public HydraHub()
        {

            //timer = new Timer(
            //                new TimerCallback(Dgom),
            //                null,
            //                2000,
            //                2000);

        }

        // This method will be called on Start button click
        public async void Dgom(object state)
        {
            var temp = 36;
            await Clients.All.SendAsync(@"{temp:" + temp.ToString() + "}");
        }

      
    }
}
