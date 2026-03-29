//HintName: G.IConsentsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IConsentsClient
    {
        /// <summary>
        /// list all consents for the user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListResponse> ListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}