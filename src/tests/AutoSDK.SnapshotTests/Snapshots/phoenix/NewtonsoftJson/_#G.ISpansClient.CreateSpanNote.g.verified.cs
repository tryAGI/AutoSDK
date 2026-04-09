//HintName: G.ISpansClient.CreateSpanNote.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Create a span note<br/>
        /// Add a note annotation to a span. Notes are special annotations that allow multiple entries per span (unlike regular annotations which are unique by name and identifier). Each note gets a unique timestamp-based identifier.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSpanNoteResponseBody> CreateSpanNoteAsync(

            global::G.CreateSpanNoteRequestBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a span note<br/>
        /// Add a note annotation to a span. Notes are special annotations that allow multiple entries per span (unlike regular annotations which are unique by name and identifier). Each note gets a unique timestamp-based identifier.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSpanNoteResponseBody> CreateSpanNoteAsync(
            global::G.SpanNoteData data,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}