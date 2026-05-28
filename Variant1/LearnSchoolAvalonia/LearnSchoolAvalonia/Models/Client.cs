using System;
using System.Collections.Generic;

namespace LearnSchoolAvalonia.Models;

public partial class Client
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateOnly? BirthDate { get; set; }

    public DateOnly? RegisterDate { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int? GenderId { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual ICollection<ServicesClient> ServicesClients { get; set; } = new List<ServicesClient>();
}
