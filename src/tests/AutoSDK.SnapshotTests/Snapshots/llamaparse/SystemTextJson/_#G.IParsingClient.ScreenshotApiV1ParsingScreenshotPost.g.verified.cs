//HintName: G.IParsingClient.ScreenshotApiV1ParsingScreenshotPost.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Screenshot
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJob> ScreenshotApiV1ParsingScreenshotPostAsync(

            global::G.BodyScreenshotApiV1ParsingScreenshotPost request,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Screenshot
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="doNotCache">
        /// Default Value: false
        /// </param>
        /// <param name="httpProxy"></param>
        /// <param name="inputS3Path"></param>
        /// <param name="inputS3Region"></param>
        /// <param name="inputUrl"></param>
        /// <param name="invalidateCache">
        /// Default Value: false
        /// </param>
        /// <param name="maxPages"></param>
        /// <param name="outputS3PathPrefix"></param>
        /// <param name="outputS3Region"></param>
        /// <param name="targetPages"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookConfigurations"></param>
        /// <param name="jobTimeoutInSeconds"></param>
        /// <param name="jobTimeoutExtraTimePerPageInSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJob> ScreenshotApiV1ParsingScreenshotPostAsync(
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            byte[]? file = default,
            string? filename = default,
            bool? doNotCache = default,
            string? httpProxy = default,
            string? inputS3Path = default,
            string? inputS3Region = default,
            string? inputUrl = default,
            bool? invalidateCache = default,
            int? maxPages = default,
            string? outputS3PathPrefix = default,
            string? outputS3Region = default,
            string? targetPages = default,
            string? webhookUrl = default,
            string? webhookConfigurations = default,
            double? jobTimeoutInSeconds = default,
            double? jobTimeoutExtraTimePerPageInSeconds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}