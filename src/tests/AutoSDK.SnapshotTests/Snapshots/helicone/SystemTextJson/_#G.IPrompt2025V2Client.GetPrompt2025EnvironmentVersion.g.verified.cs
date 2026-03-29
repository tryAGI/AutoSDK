//HintName: G.IPrompt2025V2Client.GetPrompt2025EnvironmentVersion.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025VersionString> GetPrompt2025EnvironmentVersionAsync(

            global::G.GetPrompt2025EnvironmentVersionRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025VersionString> GetPrompt2025EnvironmentVersionAsync(
            string environment,
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}