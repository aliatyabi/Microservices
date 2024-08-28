using MediatR;

namespace IDP.Application.Commands.Auth
{
    public class OtpCommand : IRequest<bool>
    {
        public required string MobileNumber { get; set; }
    }
}
