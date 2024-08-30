//HintName: G.Models.ChatCompletionRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying the format that the model must output.
    /// </summary>
    public sealed partial class ChatCompletionRequestResponseFormat
    {
        /// <summary>
        /// The type of the response format.<br/>
        /// Example: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The schema of the response format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::G.ChatCompletionRequestResponseFormatSchema? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}