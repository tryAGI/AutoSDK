//HintName: G.IApi.CreateResearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Initiate a research task<br/>
        /// Tavily Research performs comprehensive research on a given topic by conducting multiple searches, analyzing sources, and generating a detailed research report.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.research("What are the latest developments in AI?")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateResearchResponse> CreateResearchAsync(

            global::G.CreateResearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate a research task<br/>
        /// Tavily Research performs comprehensive research on a given topic by conducting multiple searches, analyzing sources, and generating a detailed research report.
        /// </summary>
        /// <param name="input">
        /// The research task or question to investigate.<br/>
        /// Example: What are the latest developments in AI?
        /// </param>
        /// <param name="model">
        /// The model used by the research agent. "mini" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. "pro" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="stream">
        /// Whether to stream the research results as they are generated. When 'true', returns a Server-Sent Events (SSE) stream. See [Streaming documentation](/documentation/api-reference/endpoint/research-streaming) for details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputSchema">
        /// A JSON Schema object that defines the structure of the research output. When provided, the research response will be structured to match this schema, ensuring a predictable and validated output shape. Must include a 'properties' field, and may optionally include 'required' field.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: {"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}
        /// </param>
        /// <param name="citationFormat">
        /// The format for citations in the research report.<br/>
        /// Default Value: numbered
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateResearchResponse> CreateResearchAsync(
            string input,
            global::G.CreateResearchRequestModel? model = default,
            bool? stream = default,
            global::G.CreateResearchRequestOutputSchema? outputSchema = default,
            global::G.CreateResearchRequestCitationFormat? citationFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}