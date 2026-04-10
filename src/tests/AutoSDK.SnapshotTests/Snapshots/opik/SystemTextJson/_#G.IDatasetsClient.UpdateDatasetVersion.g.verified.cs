//HintName: G.IDatasetsClient.UpdateDatasetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update dataset version<br/>
        /// Update a dataset version's change_description and/or add new tags
        /// </summary>
        /// <param name="versionHash"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersionPublic> UpdateDatasetVersionAsync(
            string versionHash,
            global::System.Guid id,

            global::G.DatasetVersionUpdatePublic request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dataset version<br/>
        /// Update a dataset version's change_description and/or add new tags
        /// </summary>
        /// <param name="versionHash"></param>
        /// <param name="id"></param>
        /// <param name="changeDescription">
        /// Optional description of changes in this version<br/>
        /// Example: Updated baseline version
        /// </param>
        /// <param name="tagsToAdd">
        /// Optional list of tags to add to this version<br/>
        /// Example: [production, reviewed]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersionPublic> UpdateDatasetVersionAsync(
            string versionHash,
            global::System.Guid id,
            string? changeDescription = default,
            global::System.Collections.Generic.IList<string>? tagsToAdd = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}