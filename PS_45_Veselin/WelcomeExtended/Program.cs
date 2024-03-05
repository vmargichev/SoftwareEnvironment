using System.Linq.Expressions;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using WelcomeExtended.Others;

namespace WelcomeExtended
{
    internal class Program
    {   
        
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                (
                    "John Smith",
                    "password123",
                    UserRolesEnum.STUDENT
                );

                var viewModel = new UserViewModel(user);

                var view = new UserView(viewModel);

                view.Display();

                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
            }
        }
    }

