//HintName: G.ITokensClient.Validate.g.cs
#nullable enable

namespace G
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Validate<br/>
        /// Validates a header token or cookie JWT.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ValidateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}