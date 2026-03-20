//HintName: G.ILargeLanguageModelsClient.DeleteLLM.g.cs
#nullable enable

namespace G
{
    public partial interface ILargeLanguageModelsClient
    {
        /// <summary>
        /// Delete an LLM<br/>
        /// The Delete LLM API enables users to remove a previously configured custom Large Language Model (LLM) from their Vectara account. This functionality is essential for managing active LLM configurations and ensuring that only relevant models are available for use. Built-in LLMs cannot be deleted, ensuring that core system models remain accessible.<br/>
        /// By providing an LLM identifier, users can permanently delete a model configuration, freeing up resources and maintaining an organized list of available LLMs.<br/>
        /// If successful, the API responds with `HTTP 204 No Content` status, confirming the LLM deletion.
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