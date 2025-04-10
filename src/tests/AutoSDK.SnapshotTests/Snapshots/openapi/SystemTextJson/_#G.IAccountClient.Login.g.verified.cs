//HintName: G.IAccountClient.Login.g.cs
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
        global::System.Threading.Tasks.Task<global::G.UserForLoginResponseDto> LoginAsync(
            global::G.UserForLoginRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserForLoginResponseDto> LoginAsync(
            string? currentCulture = default,
            string? userName = default,
            string? password = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}