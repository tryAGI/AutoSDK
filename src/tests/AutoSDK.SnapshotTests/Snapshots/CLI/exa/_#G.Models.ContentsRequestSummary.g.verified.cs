//HintName: G.Models.ContentsRequestSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of the webpage
    /// </summary>
    public sealed partial class ContentsRequestSummary
    {
        /// <summary>
        /// Custom query for the LLM-generated summary.<br/>
        /// Example: Main developments
        /// </summary>
        /// <example>Main developments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// JSON schema for structured output from summary. <br/>
        /// See https://json-schema.org/overview/what-is-jsonschema for JSON Schema documentation.<br/>
        /// Example: {"$schema":"http://json-schema.org/draft-07/schema#","title":"Title","type":"object","properties":{"Property 1":{"type":"string","description":"Description"},"Property 2":{"type":"string","enum":["option 1","option 2","option 3"],"description":"Description"}},"required":["Property 1"]}
        /// </summary>
        /// <example>{"$schema":"http://json-schema.org/draft-07/schema#","title":"Title","type":"object","properties":{"Property 1":{"type":"string","description":"Description"},"Property 2":{"type":"string","enum":["option 1","option 2","option 3"],"description":"Description"}},"required":["Property 1"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestSummary" /> class.
        /// </summary>
        /// <param name="query">
        /// Custom query for the LLM-generated summary.<br/>
        /// Example: Main developments
        /// </param>
        /// <param name="schema">
        /// JSON schema for structured output from summary. <br/>
        /// See https://json-schema.org/overview/what-is-jsonschema for JSON Schema documentation.<br/>
        /// Example: {"$schema":"http://json-schema.org/draft-07/schema#","title":"Title","type":"object","properties":{"Property 1":{"type":"string","description":"Description"},"Property 2":{"type":"string","enum":["option 1","option 2","option 3"],"description":"Description"}},"required":["Property 1"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestSummary(
            string? query,
            object? schema)
        {
            this.Query = query;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestSummary" /> class.
        /// </summary>
        public ContentsRequestSummary()
        {
        }
    }
}