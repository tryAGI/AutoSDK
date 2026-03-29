//HintName: G.Models.OpenAIChatCompletionChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A choice in the chat completion response.
    /// </summary>
    public sealed partial class OpenAIChatCompletionChoice
    {
        /// <summary>
        /// The role of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The content of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletionChoice" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message
        /// </param>
        /// <param name="content">
        /// The content of the message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIChatCompletionChoice(
            string? role,
            string? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletionChoice" /> class.
        /// </summary>
        public OpenAIChatCompletionChoice()
        {
        }
    }
}