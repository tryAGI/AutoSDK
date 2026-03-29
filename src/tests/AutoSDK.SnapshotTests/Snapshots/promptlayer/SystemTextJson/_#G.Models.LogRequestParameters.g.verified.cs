//HintName: G.Models.LogRequestParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model parameters including temperature, max_tokens, etc. Can also include structured output configuration via response_format.json_schema. See documentation for structured output examples.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class LogRequestParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}