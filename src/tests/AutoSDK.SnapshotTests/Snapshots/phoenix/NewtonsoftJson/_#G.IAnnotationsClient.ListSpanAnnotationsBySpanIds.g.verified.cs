//HintName: G.IAnnotationsClient.ListSpanAnnotationsBySpanIds.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Get span annotations for a list of span_ids.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="spanIds">
        /// One or more span id to fetch annotations for
        /// </param>
        /// <param name="includeAnnotationNames">
        /// Optional list of annotation names to include. If provided, only annotations with these names will be returned. 'note' annotations are excluded by default unless explicitly included in this list.
        /// </param>
        /// <param name="excludeAnnotationNames">
        /// Optional list of annotation names to exclude from results.
        /// </param>
        /// <param name="cursor">
        /// A cursor for pagination
        /// </param>
        /// <param name="limit">
        /// The maximum number of annotations to return in a single request<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpanAnnotationsResponseBody> ListSpanAnnotationsBySpanIdsAsync(
            string projectIdentifier,
            global::System.Collections.Generic.IList<string> spanIds,
            global::System.Collections.Generic.IList<string>? includeAnnotationNames = default,
            global::System.Collections.Generic.IList<string>? excludeAnnotationNames = default,
            string? cursor = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}