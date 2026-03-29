//HintName: G.IPrompt2025Client.UpdatePrompt2025Tags.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringArrayString> UpdatePrompt2025TagsAsync(
            string promptId,

            global::G.UpdatePrompt2025TagsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringArrayString> UpdatePrompt2025TagsAsync(
            string promptId,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}