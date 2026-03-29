//HintName: G.IAnnotationConfigsClient.GetAnnotationConfigByNameOrIdV1AnnotationConfigsConfigIdentifierGet.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Get an annotation configuration by ID or name
        /// </summary>
        /// <param name="configIdentifier">
        /// ID or name of the annotation configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAnnotationConfigResponseBody> GetAnnotationConfigByNameOrIdV1AnnotationConfigsConfigIdentifierGetAsync(
            string configIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}