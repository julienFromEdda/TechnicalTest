﻿namespace UserApi.Models.Entity;

public class User
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Email { get; set; }

    public required string FirstName { get; set; }
}
