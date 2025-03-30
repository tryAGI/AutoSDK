//HintName: G.ILargeLanguageModelsClient.DeleteLLM.g.cs
#nullable enable

namespace G
{
    public partial interface ILargeLanguageModelsClient
    {
        /// <summary>
        /// Delete an LLM<br/>
        /// Delete a custom LLM connection. Built-in LLMs cannot be deleted.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLLMAsync(
            string llmId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}