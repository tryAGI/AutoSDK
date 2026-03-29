//HintName: G.ISpansClient.AnnotateSpanDocuments.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Annotate Span Documents
        /// </summary>
        /// <param name="sync">
        /// If set to true, the annotations are inserted synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotateSpanDocumentsResponseBody> AnnotateSpanDocumentsAsync(

            global::G.AnnotateSpanDocumentsRequestBody request,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotate Span Documents
        /// </summary>
        /// <param name="sync">
        /// If set to true, the annotations are inserted synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotateSpanDocumentsResponseBody> AnnotateSpanDocumentsAsync(
            global::System.Collections.Generic.IList<global::G.SpanDocumentAnnotationData> data,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}