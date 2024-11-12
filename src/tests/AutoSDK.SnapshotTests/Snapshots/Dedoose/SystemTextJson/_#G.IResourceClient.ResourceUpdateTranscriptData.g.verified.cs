//HintName: G.IResourceClient.ResourceUpdateTranscriptData.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UpdateTranscriptData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="dataPath"></param>
        /// <param name="created"></param>
        /// <param name="transcriptData"></param>
        /// <param name="syncItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResourceUpdateTranscriptDataAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? id = default,
            global::System.Guid? creator = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            string? dataPath = default,
            global::System.DateTime? created = default,
            string? transcriptData = default,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem>? syncItems = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}