//HintName: G.ITemplatesClient.GetTemplatesByTemplateIDBuildsByBuildIDStatus.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get template build info
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="logsOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="level">
        /// State of the sandbox
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateBuildInfo> GetTemplatesByTemplateIDBuildsByBuildIDStatusAsync(
            string templateID,
            string buildID,
            int? logsOffset = default,
            int? limit = default,
            global::G.LogLevel? level = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}