namespace BasketballApp.Controllers
{
    public class ErrorHandler : IErrorHandler
    {
        public void reportErrors(Exception ex) {
            throw ex;
        }
    }
}
