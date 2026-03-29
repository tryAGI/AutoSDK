//HintName: G.IObjectsClient.ObjSetAliasesObjsObjectIdAliasesPut.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Set Aliases<br/>
        /// Set aliases for an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjSetAliasesRes> ObjSetAliasesObjsObjectIdAliasesPutAsync(
            string objectId,

            global::G.ObjSetAliasesBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Set Aliases<br/>
        /// Set aliases for an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="projectId"></param>
        /// <param name="digest"></param>
        /// <param name="aliases"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjSetAliasesRes> ObjSetAliasesObjsObjectIdAliasesPutAsync(
            string objectId,
            string projectId,
            string digest,
            global::System.Collections.Generic.IList<string> aliases,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}