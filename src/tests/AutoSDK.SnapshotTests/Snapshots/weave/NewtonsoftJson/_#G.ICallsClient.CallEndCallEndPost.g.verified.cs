//HintName: G.ICallsClient.CallEndCallEndPost.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call End
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallEndRes> CallEndCallEndPostAsync(

            global::G.CallEndReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call End
        /// </summary>
        /// <param name="end"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallEndRes> CallEndCallEndPostAsync(
            global::G.EndedCallSchemaForInsert end,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}