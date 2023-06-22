using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Models;

public class Deposit
{
    [Key]
    [StringLength(15)]
    public string BankTransactionId { get; set; }

    [Required]
    public DateTime TransactionTimestamp { get; set; } = DateTime.Now;

    [StringLength(65)]
    public string BankCode { get; set; }

    [Required]
    [StringLength(65)]
    public string AccountNumber { get; set; }

    [StringLength(65)]
    public string SenderBankCode { get; set; }

    [StringLength(65)]
    public string SenderAccountNumber { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    [StringLength(100)]
    public string Receiver { get; set; }

    [StringLength(200)]
    public string ReceiverFirstName { get; set; }

    [StringLength(200)]
    public string ReceiverSurname { get; set; }

    [StringLength(100)]
    public string Message { get; set; }

    public int? ResponseId { get; set; }
}
