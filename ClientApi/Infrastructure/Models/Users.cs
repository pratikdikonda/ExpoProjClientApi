namespace ClientApi.Infrastructure.Models
{
    public class Users 
    {
        public string serialNumber { get; set; }
        public string firmName { get; set; }
        public string userEmail { get; set; }

        public string userPassword { get; set; }

        public string userId    { get; set; }
        public string userMobile { get; set; }
        public bool userActive { get; set; }

        public DateTime subscribeDTM { get; set; }

        public DateTime subscribeEndDTM { get; set; }

        public string userIP { get; set; }


    }
}
