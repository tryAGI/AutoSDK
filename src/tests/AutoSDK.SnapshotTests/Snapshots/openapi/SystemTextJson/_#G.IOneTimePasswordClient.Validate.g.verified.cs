//HintName: G.IOneTimePasswordClient.Validate.g.cs
#nullable enable

namespace G
{
    public partial interface IOneTimePasswordClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="validationCode"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneTimePasswordForValidateResponseDto> ValidateAsync(
            long? userId = default,
            int? validationCode = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}