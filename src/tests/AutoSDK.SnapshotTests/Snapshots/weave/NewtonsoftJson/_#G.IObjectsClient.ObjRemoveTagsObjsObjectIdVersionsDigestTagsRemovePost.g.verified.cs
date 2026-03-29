//HintName: G.IObjectsClient.ObjRemoveTagsObjsObjectIdVersionsDigestTagsRemovePost.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Remove Tags<br/>
        /// Remove tags from an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjRemoveTagsRes> ObjRemoveTagsObjsObjectIdVersionsDigestTagsRemovePostAsync(
            string objectId,
            string digest,

            global::G.ObjTagsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Remove Tags<br/>
        /// Remove tags from an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="projectId"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjRemoveTagsRes> ObjRemoveTagsObjsObjectIdVersionsDigestTagsRemovePostAsync(
            string objectId,
            string digest,
            string projectId,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}