//HintName: G.ITagClient.TagUpdateTagAppWeight.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// UpdateTagAppWeight.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="tagAppId"></param>
        /// <param name="newWeight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagUpdateTagAppWeightResponse> TagUpdateTagAppWeightAsync(
            string? token = default,
            global::System.Guid currentProjectId = default,
            global::System.Guid tagAppId = default,
            double newWeight = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}