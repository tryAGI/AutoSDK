//HintName: G.Models.ContentsRequestSummarySchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON schema for structured output from summary. <br/>
    /// See https://json-schema.org/overview/what-is-jsonschema for JSON Schema documentation.<br/>
    /// Example: {"$schema":"http://json-schema.org/draft-07/schema#","title":"Title","type":"object","properties":{"Property 1":{"type":"string","description":"Description"},"Property 2":{"type":"string","enum":["option 1","option 2","option 3"],"description":"Description"}},"required":["Property 1"]}
    /// </summary>
    public sealed partial class ContentsRequestSummarySchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}