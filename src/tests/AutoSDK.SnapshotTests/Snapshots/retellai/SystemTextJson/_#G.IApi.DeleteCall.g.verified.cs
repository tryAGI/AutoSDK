//HintName: G.IApi.DeleteCall.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete a specific call and its associated data
        /// </summary>
        /// <param name="callId">
        /// Example: 119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteCallAsync(
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}