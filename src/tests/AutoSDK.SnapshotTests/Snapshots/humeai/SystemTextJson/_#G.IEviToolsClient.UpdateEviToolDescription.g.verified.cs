//HintName: G.IEviToolsClient.UpdateEviToolDescription.g.cs
#nullable enable

namespace G
{
    public partial interface IEviToolsClient
    {
        /// <summary>
        /// Update EVI tool description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnUserDefinedTool> UpdateEviToolDescriptionAsync(
            string id,
            int version,

            global::G.PostedUserDefinedToolVersionDescription request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update EVI tool description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="versionDescription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnUserDefinedTool> UpdateEviToolDescriptionAsync(
            string id,
            int version,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}