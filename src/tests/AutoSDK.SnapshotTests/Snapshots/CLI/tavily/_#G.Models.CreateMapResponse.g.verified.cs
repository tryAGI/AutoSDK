//HintName: G.Models.CreateMapResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMapResponse
    {
        /// <summary>
        /// The base URL that was mapped.<br/>
        /// Example: docs.tavily.com
        /// </summary>
        /// <example>docs.tavily.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// A list of URLs that were discovered during the mapping.<br/>
        /// Example: [https://docs.tavily.com/welcome, https://docs.tavily.com/documentation/api-credits, https://docs.tavily.com/documentation/about]
        /// </summary>
        /// <example>[https://docs.tavily.com/welcome, https://docs.tavily.com/documentation/api-credits, https://docs.tavily.com/documentation/about]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<string>? Results { get; set; }

        /// <summary>
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </summary>
        /// <example>1.23F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        public float? ResponseTime { get; set; }

        /// <summary>
        /// Credit usage details for the request.<br/>
        /// Example: {"credits":1}
        /// </summary>
        /// <example>{"credits":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public object? Usage { get; set; }

        /// <summary>
        /// A unique request identifier you can share with customer support to help resolve issues with specific requests.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174111</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMapResponse" /> class.
        /// </summary>
        /// <param name="baseUrl">
        /// The base URL that was mapped.<br/>
        /// Example: docs.tavily.com
        /// </param>
        /// <param name="results">
        /// A list of URLs that were discovered during the mapping.<br/>
        /// Example: [https://docs.tavily.com/welcome, https://docs.tavily.com/documentation/api-credits, https://docs.tavily.com/documentation/about]
        /// </param>
        /// <param name="responseTime">
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </param>
        /// <param name="usage">
        /// Credit usage details for the request.<br/>
        /// Example: {"credits":1}
        /// </param>
        /// <param name="requestId">
        /// A unique request identifier you can share with customer support to help resolve issues with specific requests.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMapResponse(
            string? baseUrl,
            global::System.Collections.Generic.IList<string>? results,
            float? responseTime,
            object? usage,
            string? requestId)
        {
            this.BaseUrl = baseUrl;
            this.Results = results;
            this.ResponseTime = responseTime;
            this.Usage = usage;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMapResponse" /> class.
        /// </summary>
        public CreateMapResponse()
        {
        }
    }
}