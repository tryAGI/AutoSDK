//HintName: G.ILlmsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface ILlmsClient
    {
        /// <summary>
        /// Get an LLM<br/>
        /// The Get LLM API allows users to retrieve details about a specific Large Language Model (LLM) that has been configured within the Vectara platform. This API provides metadata about the LLM, including its name, description, model type, API endpoint, and authentication method.<br/>
        /// Use this API to verify model configurations, confirm connectivity details, and ensure that the correct LLM is being utilized within their workflows.<br/>
        /// ## Authentication methods<br/>
        /// The request requires authentication details, and you can provide them either as a Bearer token or custom header-based authentication.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Llm> GetAsync(
            string llmId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}