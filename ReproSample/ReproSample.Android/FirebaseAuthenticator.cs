using Firebase.Auth;
using ReproSample.Droid;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(FirebaseAuthenticator))]
namespace ReproSample.Droid
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator
    {
        public async Task TestSingInAndVerification(string email, string password)
        {
            // запрос входа польователя с адресом и паролем
            var authResult = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);

            // получение токена
            var getTokenResult = await authResult.User.GetIdTokenAsync(false);
            var token = getTokenResult.Token;

            await FirebaseAuth.Instance.CurrentUser.SendEmailVerificationAsync(ActionCodeSettings.NewBuilder().Build());
        }
    }
}