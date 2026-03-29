//HintName: G.IObjectsClient.ObjRemoveAliasesObjsObjectIdAliasesRemovePost.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Remove Aliases<br/>
        /// Remove aliases from an object.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjRemoveAliasesRes> ObjRemoveAliasesObjsObjectIdAliasesRemovePostAsync(
            string objectId,

            global::G.ObjRemoveAliasesBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Remove Aliases<br/>
        /// Remove aliases from an object.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="projectId"></param>
        /// <param name="aliases"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjRemoveAliasesRes> ObjRemoveAliasesObjsObjectIdAliasesRemovePostAsync(
            string objectId,
            string projectId,
            global::System.Collections.Generic.IList<string> aliases,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}