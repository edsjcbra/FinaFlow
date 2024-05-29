﻿using System.ComponentModel.DataAnnotations;

namespace FinaFlow.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Invalid Title")]
    [MaxLength(80, ErrorMessage = "Title must have max. 80 characters")]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Invalid Description")]
    public string Description { get; set; } = String.Empty;
}