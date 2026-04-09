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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjCreateRes> ObjCreateObjCreatePostAsync(

            global::G.ObjCreateReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Create
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjCreateRes> ObjCreateObjCreatePostAsync(
            global::G.ObjSchemaForInsert obj,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}