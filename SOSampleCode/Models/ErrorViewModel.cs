using System;
using System.ComponentModel.DataAnnotations;

namespace SOSampleCode.Models
{
    public class Book
    {
        [Required]
        public string BookName { set; get; }
    }
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}