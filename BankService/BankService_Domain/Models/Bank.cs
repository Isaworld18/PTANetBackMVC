﻿/************************************************************************************************************
 * Julio's tech test for Alicunde Job position
 ************************************************************************************************************/

namespace BankService_Domain.Models;

/// <summary>
/// code auto generated by this command :
/// Scaffold-DbContext "Data Source=LAPTOP-0PL7RF4D\\SQLEXPRESS;Initial Catalog=BankServiceDB;Integrated Security=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
/// on EF issue on .NET framework
/// </summary>
public partial class Bank
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Bic { get; set; } = null!;

    public string Country { get; set; } = null!;
}
