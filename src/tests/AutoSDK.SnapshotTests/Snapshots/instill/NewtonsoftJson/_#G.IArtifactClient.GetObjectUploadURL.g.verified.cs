//HintName: G.IArtifactClient.GetObjectUploadURL.g.cs
#nullable enable

namespace G
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get Object Upload URL<br/>
        /// Returns the upload URL of an object.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectName"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="lastModifiedTime"></param>
        /// <param name="objectExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetObjectUploadURLResponse> GetObjectUploadURLAsync(
            string namespaceId,
            string objectName,
            int? urlExpireDays = default,
            global::System.DateTime? lastModifiedTime = default,
            int? objectExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}