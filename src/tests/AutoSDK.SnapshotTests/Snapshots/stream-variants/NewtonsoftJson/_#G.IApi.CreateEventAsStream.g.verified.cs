//HintName: G.IApi.CreateEventAsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.EventChunk> CreateEventAsStreamAsync(

            global::G.EventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.EventChunk> CreateEventAsStreamAsync(
            string input,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}