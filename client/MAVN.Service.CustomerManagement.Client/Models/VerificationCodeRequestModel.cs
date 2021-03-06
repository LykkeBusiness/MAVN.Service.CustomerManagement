using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace MAVN.Service.CustomerManagement.Client.Models
{
    /// <summary>
    /// Verification code request model
    /// </summary>
    [PublicAPI]
    public class VerificationCodeRequestModel
    {
        /// <summary>CustomerId</summary>
        [Required]
        public string CustomerId { get; set; }
    }
}
