﻿namespace AAA.ERP.OutputDtos.BaseDtos;

public class BaseDto
{
    public Guid Id { get; set; }
    public string? Notes { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}
