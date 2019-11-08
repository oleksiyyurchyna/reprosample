using System.Threading.Tasks;

namespace ReproSample
{
    public interface IFirebaseAuthenticator
    {
        Task TestSingInAndVerification(string email, string password);
    }
}
