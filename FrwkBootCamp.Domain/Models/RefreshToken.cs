using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FrameBook.Domain.Models
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Expires { get; set; }
        [NotMapped]
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created { get; set; }
        public string CreatedByIp { get; set; }
        public DateTime? Revoked { get; set; }
        public string? RevokedByIp { get; set; }
        public string? ReplaceByToken { get; set; }
        [NotMapped]
        public bool IsActive => Revoked == null && !IsExpired;
    }
}
