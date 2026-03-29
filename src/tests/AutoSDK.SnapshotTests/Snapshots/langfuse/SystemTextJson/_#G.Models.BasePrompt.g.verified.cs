//HintName: G.Models.BasePrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasePrompt
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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// List of deployment labels of this prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// List of tags. Used to filter via UI and API. The same across versions of a prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Commit message for this prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMessage")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// The dependency resolution graph for the current prompt. Null if the prompt has no dependencies or if `resolve=false` was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolutionGraph")]
        public object? ResolutionGraph { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePrompt" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="config"></param>
        /// <param name="labels">
        /// List of deployment labels of this prompt version.
        /// </param>
        /// <param name="tags">
        /// List of tags. Used to filter via UI and API. The same across versions of a prompt.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for this prompt version.
        /// </param>
        /// <param name="resolutionGraph">
        /// The dependency resolution graph for the current prompt. Null if the prompt has no dependencies or if `resolve=false` was used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasePrompt(
            string name,
            int version,
            object config,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<string> tags,
            string? commitMessage,
            object? resolutionGraph)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.CommitMessage = commitMessage;
            this.ResolutionGraph = resolutionGraph;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePrompt" /> class.
        /// </summary>
        public BasePrompt()
        {
        }
    }
}