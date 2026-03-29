//HintName: G.Models.CreateExtractResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExtractResponse
    {
        /// <summary>
        /// A list of extracted content from the provided URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.CreateExtractResponseResult>? Results { get; set; }

        /// <summary>
        /// A list of URLs that could not be processed.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_results")]
        public global::System.Collections.Generic.IList<global::G.CreateExtractResponseFailedResult>? FailedResults { get; set; }

        /// <summary>
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 0.02F
        /// </summary>
        /// <example>0.02F</example>
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
        /// Initializes a new instance of the <see cref="CreateExtractResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// A list of extracted content from the provided URLs.
        /// </param>
        /// <param name="failedResults">
        /// A list of URLs that could not be processed.<br/>
        /// Example: []
        /// </param>
        /// <param name="responseTime">
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 0.02F
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
        public CreateExtractResponse(
            global::System.Collections.Generic.IList<global::G.CreateExtractResponseResult>? results,
            global::System.Collections.Generic.IList<global::G.CreateExtractResponseFailedResult>? failedResults,
            float? responseTime,
            object? usage,
            string? requestId)
        {
            this.Results = results;
            this.FailedResults = failedResults;
            this.ResponseTime = responseTime;
            this.Usage = usage;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractResponse" /> class.
        /// </summary>
        public CreateExtractResponse()
        {
        }
    }
}