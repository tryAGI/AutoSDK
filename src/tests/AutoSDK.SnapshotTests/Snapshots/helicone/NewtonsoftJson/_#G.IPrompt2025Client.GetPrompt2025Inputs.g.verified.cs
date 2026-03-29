//HintName: G.IPrompt2025Client.GetPrompt2025Inputs.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025InputString> GetPrompt2025InputsAsync(
            string promptId,
            string versionId,
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}