//HintName: G.IManageClient.GetApiTerms.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve the latest terms of service for API usage.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetApiTermsResponse> GetApiTermsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}