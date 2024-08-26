using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Commands.User
{
    public record UserCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "وارد کردن نام الزامی است")]
        [MinLength(length: 3, ErrorMessage = "نام باید دارای حداقل {0} کاراکتر باشد")]
        public required string Fullname { get; set; }

        public required string NationalCode { get; set; }
    }
}
