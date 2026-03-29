//HintName: G.IResponsesClient.CreateResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Creates a model response
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> CreateResponseAsync(

            global::G.CreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a model response
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> CreateResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}