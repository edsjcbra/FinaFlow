﻿using System.ComponentModel.DataAnnotations;
using FinaFlow.Core.Enums;
using FinaFlow.Core.Models;

namespace FinaFlow.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Invalid Title")]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Invalid Type")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
    
    [Required(ErrorMessage = "Invalid Amount")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "Invalid Category")]
    public long CategoryId { get; set; }
    
    [Required(ErrorMessage = "Invalid Date")]
    public DateTime? PaidOrReceivedAt { get; set; }
}