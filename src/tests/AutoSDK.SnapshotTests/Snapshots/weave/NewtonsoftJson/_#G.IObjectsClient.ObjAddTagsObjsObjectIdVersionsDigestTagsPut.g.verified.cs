//HintName: G.IObjectsClient.ObjAddTagsObjsObjectIdVersionsDigestTagsPut.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Add Tags<br/>
        /// Add tags to an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjAddTagsRes> ObjAddTagsObjsObjectIdVersionsDigestTagsPutAsync(
            string objectId,
            string digest,

            global::G.ObjTagsBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Add Tags<br/>
        /// Add tags to an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="projectId"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjAddTagsRes> ObjAddTagsObjsObjectIdVersionsDigestTagsPutAsync(
            string objectId,
            string digest,
            string projectId,
            global::System.Collections.Generic.IList<string> tags,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}