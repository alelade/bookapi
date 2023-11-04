﻿namespace Shared.Data;

public abstract class EntityBase
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; } 
    public Guid CreatedBy { get; set; }   
}