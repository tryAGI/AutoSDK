//HintName: G.IAnnotationConfigsClient.ListAnnotationConfigsV1AnnotationConfigsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// List annotation configurations<br/>
        /// Retrieve a paginated list of all annotation configurations in the system.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded annotation config ID)
        /// </param>
        /// <param name="limit">
        /// Maximum number of configs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAnnotationConfigsResponseBody> ListAnnotationConfigsV1AnnotationConfigsGetAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}