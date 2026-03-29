//HintName: G.IApi.AddFollowup.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Add followup<br/>
        /// Add a followup instruction to an existing cloud agent
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddFollowupResponse> AddFollowupAsync(
            string id,

            global::G.AddFollowupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add followup<br/>
        /// Add a followup instruction to an existing cloud agent
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddFollowupResponse> AddFollowupAsync(
            string id,
            global::G.AddFollowupRequestPrompt prompt,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}