//HintName: G.Models.LLMConfigResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response format for the model's output. Supports text, json_object, and json_schema (structured outputs). Can be set via model_settings.
    /// </summary>
    public sealed partial class LLMConfigResponseFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}