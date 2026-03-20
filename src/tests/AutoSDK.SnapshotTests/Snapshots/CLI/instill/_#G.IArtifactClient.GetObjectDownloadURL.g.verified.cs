//HintName: G.IArtifactClient.GetObjectDownloadURL.g.cs
#nullable enable

namespace G
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get Object Download URL<br/>
        /// Returns the download URL of an object.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectUid"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetObjectDownloadURLResponse> GetObjectDownloadURLAsync(
            string namespaceId,
            string objectUid,
            int? urlExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}