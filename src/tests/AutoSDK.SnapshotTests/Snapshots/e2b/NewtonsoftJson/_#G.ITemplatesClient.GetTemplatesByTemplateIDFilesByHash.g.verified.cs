//HintName: G.ITemplatesClient.GetTemplatesByTemplateIDFilesByHash.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get an upload link for a tar file containing build layer files
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="hash">
        /// Hash of the files
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateBuildFileUpload> GetTemplatesByTemplateIDFilesByHashAsync(
            string templateID,
            string hash,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}