using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Domain.DTOs
{
    public class OtpDto
    {
        public int UserId { get; set; }

        public required string OtpCode { get; set; }

        public bool IsUsed { get; set; }
    }
}
