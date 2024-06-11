//HintName: G.Models.AssistantsApiResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object describing the expected output of the model. If `json_object` only `function` type `tools` are allowed to be passed to the Run. If `text` the model can return text or any value needed.
    /// </summary>
    public sealed partial class AssistantsApiResponseFormat
    {
        /// <summary>
        /// Must be one of `text` or `json_object`.
        /// <br/>Default Value: text
        /// <br/>Example: json_object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter))]
        public global::G.AssistantsApiResponseFormatType? Type { get; set; } = global::G.AssistantsApiResponseFormatType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}