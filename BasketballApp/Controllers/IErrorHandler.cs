
namespace BasketballApp.Controllers
{
    public interface IErrorHandler
    {
        void reportErrors(Exception ex);
    }
}