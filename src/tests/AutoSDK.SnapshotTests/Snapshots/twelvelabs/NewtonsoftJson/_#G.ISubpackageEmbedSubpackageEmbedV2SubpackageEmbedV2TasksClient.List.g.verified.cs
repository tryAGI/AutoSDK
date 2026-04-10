//HintName: G.ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient
    {
        /// <summary>
        /// List async embedding tasks<br/>
        /// This method returns a list of the async embedding tasks in your account. The platform returns your async embedding tasks sorted by creation date, with the newest at the top of the list.
        /// </summary>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="status"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedV2TasksListResponse200> ListAsync(
            string xApiKey,
            string? startedAt = default,
            string? endedAt = default,
            string? status = default,
            int? page = default,
            int? pageLimit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}