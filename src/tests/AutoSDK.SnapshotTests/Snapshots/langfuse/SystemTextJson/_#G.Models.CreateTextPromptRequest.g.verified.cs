//HintName: G.Models.CreateTextPromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextPromptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTextPromptTypeJsonConverter))]
        public global::G.CreateTextPromptType? Type { get; set; }

        /// <summary>
        /// List of deployment labels of this prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// List of tags to apply to all versions of this prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Commit message for this prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMessage")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextPromptRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="config"></param>
        /// <param name="type"></param>
        /// <param name="labels">
        /// List of deployment labels of this prompt version.
        /// </param>
        /// <param name="tags">
        /// List of tags to apply to all versions of this prompt.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for this prompt version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextPromptRequest(
            string name,
            string prompt,
            object? config,
            global::G.CreateTextPromptType? type,
            global::System.Collections.Generic.IList<string>? labels,
            global::System.Collections.Generic.IList<string>? tags,
            string? commitMessage)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Config = config;
            this.Type = type;
            this.Labels = labels;
            this.Tags = tags;
            this.CommitMessage = commitMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextPromptRequest" /> class.
        /// </summary>
        public CreateTextPromptRequest()
        {
        }
    }
}