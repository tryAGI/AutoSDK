//HintName: G.ILLMsTxtClient.GetLLMsTxtStatus.g.cs
#nullable enable

namespace G
{
    public partial interface ILLMsTxtClient
    {
        /// <summary>
        /// Get the status and results of an LLMs.txt generation job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetLLMsTxtStatusResponse> GetLLMsTxtStatusAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}