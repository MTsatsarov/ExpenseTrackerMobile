
namespace ExpenseTrackerMobile.Services.Interfaces
{
	public interface IAccountService
	{
		Task LoginUser(string email, string password);
	}
}
