//HintName: G.ITagClient.UpdateTagAppWeight.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// UpdateTagAppWeight<br/>
        /// UpdateTagAppWeight
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTagAppWeightAsync(
            global::G.UpdateTagAppWeightRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateTagAppWeight<br/>
        /// UpdateTagAppWeight
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="tagAppId"></param>
        /// <param name="newWeight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTagAppWeightAsync(
            global::System.Guid currentProjectId,
            global::System.Guid tagAppId,
            double newWeight,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}