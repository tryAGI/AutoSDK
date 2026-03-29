//HintName: G.IApi.GetCall.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve details of a specific call
        /// </summary>
        /// <param name="callId">
        /// Example: 119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.V2CallResponse> GetCallAsync(
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}