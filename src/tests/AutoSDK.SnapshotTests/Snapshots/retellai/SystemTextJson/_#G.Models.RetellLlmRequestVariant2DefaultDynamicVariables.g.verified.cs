//HintName: G.Models.RetellLlmRequestVariant2DefaultDynamicVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default dynamic variables represented as key-value pairs of strings. These are injected into your Retell LLM prompt and tool description when specific values are not provided in a request. Only applicable for Retell LLM.<br/>
    /// Example: {"customer_name":"John Doe"}
    /// </summary>
    public sealed partial class RetellLlmRequestVariant2DefaultDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}