//HintName: G.ISpansClient.DeleteSpanById.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Delete span by id<br/>
        /// Delete span by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpanByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}