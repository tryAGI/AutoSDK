//HintName: G.IOneTimePasswordClient.ValidateSecurityWords.g.cs
#nullable enable

namespace G
{
    public partial interface IOneTimePasswordClient
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
        global::System.Threading.Tasks.Task<global::G.SecurityWordsForOtpResponseDto> ValidateSecurityWordsAsync(
            global::G.SecurityWordsForOtpRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="words"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SecurityWordsForOtpResponseDto> ValidateSecurityWordsAsync(
            string? currentCulture = default,
            long? userId = default,
            string? words = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}