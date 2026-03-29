//HintName: G.IObjectsClient.ObjCreateObjCreatePost.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjCreateRes> ObjCreateObjCreatePostAsync(

            global::G.ObjCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Create
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjCreateRes> ObjCreateObjCreatePostAsync(
            global::G.ObjSchemaForInsert obj,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}