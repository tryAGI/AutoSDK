//HintName: G.Models.SnippetReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnippetReference
    {
        /// <summary>
        /// The name of the snippet prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptName { get; set; }

        /// <summary>
        /// The version number of the snippet used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The release label of the snippet, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetReference" /> class.
        /// </summary>
        /// <param name="promptName">
        /// The name of the snippet prompt template.
        /// </param>
        /// <param name="version">
        /// The version number of the snippet used.
        /// </param>
        /// <param name="label">
        /// The release label of the snippet, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnippetReference(
            string promptName,
            int version,
            string? label)
        {
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.Version = version;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetReference" /> class.
        /// </summary>
        public SnippetReference()
        {
        }
    }
}