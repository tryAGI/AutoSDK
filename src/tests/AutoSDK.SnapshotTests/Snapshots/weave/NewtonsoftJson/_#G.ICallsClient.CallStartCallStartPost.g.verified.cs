//HintName: G.ICallsClient.CallStartCallStartPost.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Start
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallStartRes> CallStartCallStartPostAsync(

            global::G.CallStartReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Start
        /// </summary>
        /// <param name="start"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallStartRes> CallStartCallStartPostAsync(
            global::G.StartedCallSchemaForInsert start,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}