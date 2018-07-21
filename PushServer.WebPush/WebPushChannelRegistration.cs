using PushServer.PushConfiguration.Abstractions.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PushServer.WebPush
{
    public class WebPushChannelRegistration
    {
        [Required]
        public string Endpoint { get; set; }
        public DateTime? ExpirationTime { get; set; }
        public string BrowserInfo { get; set; }
        public PushChannelOptions Options { get; set; }
        [Required]
        public WebPushChannelKeys Keys { get; set; }
    }
}
