//HintName: G.IApi.ResearchControllerGetResearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get a research request by id<br/>
        /// Retrieve research by ID. Add ?stream=true for real-time SSE updates.
        /// </summary>
        /// <param name="researchId"></param>
        /// <param name="stream"></param>
        /// <param name="events"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResearchDtoClass> ResearchControllerGetResearchAsync(
            string researchId,
            string stream,
            string events,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}