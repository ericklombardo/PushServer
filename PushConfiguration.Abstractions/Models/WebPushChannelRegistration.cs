using System;
using System.ComponentModel.DataAnnotations;

namespace PushServer.PushConfiguration.Abstractions.Models
{
    public class WebPushChannelRegistration
    {
        [Required]
        public string Endpoint { get; set; }
        public DateTime? ExpirationTime { get; set; }
        [Required]
        public string P256dhKey { get; set; }
        [Required]
        public string AuthKey { get; set; }
        public string BrowserInfo { get; set; }
        public PushChannelOptions Options { get; set; }
    }
}
