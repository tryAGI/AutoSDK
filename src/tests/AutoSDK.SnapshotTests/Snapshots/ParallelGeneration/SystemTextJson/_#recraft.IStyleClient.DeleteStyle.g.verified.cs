//HintName: recraft.IStyleClient.DeleteStyle.g.cs
#nullable enable

namespace recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Delete Style
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteStyleAsync(
            global::System.Guid styleId,
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}