﻿using PriceState.Data.Enums;

namespace PriceState.Data.Models;

public class User
{
    public long Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string SureName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string PasswordKey { get; set; } = string.Empty;
    public Region Region { get; set; }

    public int RegionId { get; set; }

    public EnumUserRole Role { get; set; } = EnumUserRole.User;

    public List<MailToken> Tokens { get; set; } = null!;
}