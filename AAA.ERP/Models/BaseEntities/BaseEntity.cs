﻿namespace AAA.ERP.Models.BaseEntities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public Guid? CreatedBy { get; set; } 
    public Guid? ModifiedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public string? Notes { get; set; }
}