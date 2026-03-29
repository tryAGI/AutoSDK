//HintName: G.IAnnotationConfigsClient.UpdateAnnotationConfigV1AnnotationConfigsConfigIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Update an annotation configuration
        /// </summary>
        /// <param name="configId">
        /// ID of the annotation configuration
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateAnnotationConfigResponseBody> UpdateAnnotationConfigV1AnnotationConfigsConfigIdPutAsync(
            string configId,

            global::G.CreateAnnotationConfigData request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}