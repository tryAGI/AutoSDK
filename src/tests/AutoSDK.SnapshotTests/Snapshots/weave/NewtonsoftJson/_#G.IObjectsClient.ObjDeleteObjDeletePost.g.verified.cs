//HintName: G.IObjectsClient.ObjDeleteObjDeletePost.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjDeleteRes> ObjDeleteObjDeletePostAsync(

            global::G.ObjDeleteReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Delete
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="objectId"></param>
        /// <param name="digests">
        /// List of digests to delete. If not provided, all digests for the object will be deleted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjDeleteRes> ObjDeleteObjDeletePostAsync(
            string projectId,
            string objectId,
            global::System.Collections.Generic.IList<string>? digests = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}