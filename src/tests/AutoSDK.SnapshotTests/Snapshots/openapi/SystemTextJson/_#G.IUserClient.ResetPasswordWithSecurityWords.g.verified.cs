//HintName: G.IUserClient.ResetPasswordWithSecurityWords.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
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
        global::System.Threading.Tasks.Task<string> ResetPasswordWithSecurityWordsAsync(
            global::G.UserForResetPasswordSecurityWordsRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userName"></param>
        /// <param name="securityWords"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResetPasswordWithSecurityWordsAsync(
            string? currentCulture = default,
            string? userName = default,
            string? securityWords = default,
            string? password = default,
            string? confirmPassword = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}