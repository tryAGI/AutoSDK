//HintName: G.IPrompt2025V2Client.GetPrompt2025Version.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025V2Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025VersionString> GetPrompt2025VersionAsync(

            global::G.GetPrompt2025VersionRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025VersionString> GetPrompt2025VersionAsync(
            string promptVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}