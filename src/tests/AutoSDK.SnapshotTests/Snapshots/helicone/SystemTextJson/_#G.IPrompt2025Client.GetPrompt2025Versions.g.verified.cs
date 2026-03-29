//HintName: G.IPrompt2025Client.GetPrompt2025Versions.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025VersionArrayString> GetPrompt2025VersionsAsync(

            global::G.GetPrompt2025VersionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="majorVersion"></param>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025VersionArrayString> GetPrompt2025VersionsAsync(
            string promptId,
            double? majorVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}