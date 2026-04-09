//HintName: G.ITemplatesClient.GetTemplatesByTemplateIDBuildsByBuildIDLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get template build logs
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="direction">
        /// Direction of the logs that should be returned
        /// </param>
        /// <param name="level">
        /// State of the sandbox
        /// </param>
        /// <param name="source">
        /// Source of the logs that should be returned
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateBuildLogsResponse> GetTemplatesByTemplateIDBuildsByBuildIDLogsAsync(
            string templateID,
            string buildID,
            long? cursor = default,
            int? limit = default,
            global::G.LogsDirection? direction = default,
            global::G.LogLevel? level = default,
            global::G.LogsSource? source = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}