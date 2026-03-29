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
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The content of the message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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