//HintName: G.ITemplatesClient.TemplatesGetTemplateSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get template snapshot (Cloud-only)<br/>
        /// Get a snapshot of the template version, this will return the template state at a specific version
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesGetTemplateSnapshotResponse> TemplatesGetTemplateSnapshotAsync(
            string projectId,
            string templateVersion,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}