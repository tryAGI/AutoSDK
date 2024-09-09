//HintName: G.Models.InputJsonBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A delta in a streaming input JSON.
    /// </summary>
    public sealed partial class InputJsonBlockDelta
    {
        /// <summary>
        /// The partial JSON delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_json")]
        public string? PartialJson { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: input_json_delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}