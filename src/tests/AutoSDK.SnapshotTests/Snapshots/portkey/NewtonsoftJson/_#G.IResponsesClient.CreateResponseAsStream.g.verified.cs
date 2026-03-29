//HintName: G.IResponsesClient.CreateResponseAsStream.g.cs
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
        global::System.Collections.Generic.IAsyncEnumerable<global::G.ResponseStreamEvent> CreateResponseAsStreamAsync(

            global::G.CreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a model response
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.ResponseStreamEvent> CreateResponseAsStreamAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}