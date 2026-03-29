//HintName: G.Models.CreatePrompt2025Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePrompt2025Request
    {
        /// <summary>
        /// Simplified interface for the OpenAI Chat request format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIChatRequest PromptBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrompt2025Request" /> class.
        /// </summary>
        /// <param name="promptBody">
        /// Simplified interface for the OpenAI Chat request format
        /// </param>
        /// <param name="tags"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePrompt2025Request(
            global::G.OpenAIChatRequest promptBody,
            global::System.Collections.Generic.IList<string> tags,
            string name)
        {
            this.PromptBody = promptBody ?? throw new global::System.ArgumentNullException(nameof(promptBody));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrompt2025Request" /> class.
        /// </summary>
        public CreatePrompt2025Request()
        {
        }
    }
}