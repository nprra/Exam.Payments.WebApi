﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Exam.Payments.WebApi.Domain.Logger
{
    public class Logs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string Exception { get; set; }
        public string Logger { get; set; }
        public string Url { get; set; }
    }
}
