//HintName: G.IAccountClient.Register.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterAsync(
            global::G.UserForRegisterRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="legId"></param>
        /// <param name="referralUserId"></param>
        /// <param name="referralUserName"></param>
        /// <param name="confirmEmailAddress"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="smart"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="addressLine1"></param>
        /// <param name="city"></param>
        /// <param name="countryIsoCode"></param>
        /// <param name="xTera">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterAsync(
            string? currentCulture = default,
            int? legId = default,
            long? referralUserId = default,
            string? referralUserName = default,
            string? confirmEmailAddress = default,
            string? password = default,
            string? confirmPassword = default,
            bool? smart = default,
            string? firstName = default,
            string? lastName = default,
            string? userName = default,
            string? email = default,
            string? phoneNumber = default,
            string? addressLine1 = default,
            string? city = default,
            string? countryIsoCode = default,
            bool? xTera = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}