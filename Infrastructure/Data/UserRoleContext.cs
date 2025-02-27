using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class UserRoleContext : DbContext
{
	public DbSet<UserRole> Roles { get; set; }

	public UserRoleContext(DbContextOptions<UserRoleContext> options) : base(options)
	{
	}
}
