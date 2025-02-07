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
        /// The schema of the response format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::System.Collections.Generic.Dictionary<string, string>? Schema { get; set; }

        /// <summary>
        /// The type of the response format.<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestResponseFormat" /> class.
        /// </summary>
        /// <param name="schema">
        /// The schema of the response format.
        /// </param>
        /// <param name="type">
        /// The type of the response format.<br/>
        /// Example: json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestResponseFormat(
            global::System.Collections.Generic.Dictionary<string, string>? schema,
            string? type)
        {
            this.Schema = schema;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestResponseFormat" /> class.
        /// </summary>
        public ChatCompletionRequestResponseFormat()
        {
        }
    }
}