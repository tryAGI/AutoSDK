//HintName: G.IUserClient.ResetPassword.g.cs
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
        global::System.Threading.Tasks.Task<global::G.UserForResetPasswordResponseDto> ResetPasswordAsync(
            global::G.UserForResetPasswordRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="code"></param>
        /// <param name="currentPassword"></param>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserForResetPasswordResponseDto> ResetPasswordAsync(
            string? currentCulture = default,
            string? code = default,
            string? currentPassword = default,
            long? id = default,
            string? username = default,
            string? password = default,
            string? confirmPassword = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}