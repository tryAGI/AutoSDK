//HintName: G.ISecurityClient.SecurityResetUserPasswordByEmail.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// ResetUserPasswordByEmail.
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> SecurityResetUserPasswordByEmailAsync(
            string? userEmail = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}