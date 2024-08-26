using IDP.Domain.Entities.BaseEntities;

namespace IDP.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string Fullname { get; set; }

        public required string NationalCode { get; set; }

        public required string Username { get; set; }

        public required string Password { get; set; }

        public required string Salt { get; set; }
    }
}
