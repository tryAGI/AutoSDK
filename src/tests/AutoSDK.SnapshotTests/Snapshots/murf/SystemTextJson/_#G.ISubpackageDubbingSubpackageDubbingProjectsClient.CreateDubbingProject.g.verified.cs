//HintName: G.ISubpackageDubbingSubpackageDubbingProjectsClient.CreateDubbingProject.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageDubbingSubpackageDubbingProjectsClient
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectResponse> CreateDubbingProjectAsync(

            global::G.ApiCreateProjectRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="name">
        /// Your Project Name
        /// </param>
        /// <param name="sourceLocale">
        /// Source Locale
        /// </param>
        /// <param name="dubbingType"></param>
        /// <param name="description"></param>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectResponse> CreateDubbingProjectAsync(
            string name,
            global::G.ApiCreateProjectRequestDubbingType dubbingType,
            global::System.Collections.Generic.IList<string> targetLocales,
            string? sourceLocale = default,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}