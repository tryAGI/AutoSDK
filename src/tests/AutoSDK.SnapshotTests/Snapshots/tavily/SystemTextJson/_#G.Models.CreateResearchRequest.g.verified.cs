//HintName: G.Models.CreateResearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResearchRequest
    {
        /// <summary>
        /// The research task or question to investigate.<br/>
        /// Example: What are the latest developments in AI?
        /// </summary>
        /// <example>What are the latest developments in AI?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The model used by the research agent. "mini" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. "pro" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateResearchRequestModelJsonConverter))]
        public global::G.CreateResearchRequestModel? Model { get; set; }

        /// <summary>
        /// Whether to stream the research results as they are generated. When 'true', returns a Server-Sent Events (SSE) stream. See [Streaming documentation](/documentation/api-reference/endpoint/research-streaming) for details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// A JSON Schema object that defines the structure of the research output. When provided, the research response will be structured to match this schema, ensuring a predictable and validated output shape. Must include a 'properties' field, and may optionally include 'required' field.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: {"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}
        /// </summary>
        /// <example>{"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public global::G.CreateResearchRequestOutputSchema? OutputSchema { get; set; }

        /// <summary>
        /// The format for citations in the research report.<br/>
        /// Default Value: numbered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateResearchRequestCitationFormatJsonConverter))]
        public global::G.CreateResearchRequestCitationFormat? CitationFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResearchRequest(
            string input,
            global::G.CreateResearchRequestModel? model,
            bool? stream,
            global::G.CreateResearchRequestOutputSchema? outputSchema,
            global::G.CreateResearchRequestCitationFormat? citationFormat)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.Stream = stream;
            this.OutputSchema = outputSchema;
            this.CitationFormat = citationFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequest" /> class.
        /// </summary>
        public CreateResearchRequest()
        {
        }
    }
}