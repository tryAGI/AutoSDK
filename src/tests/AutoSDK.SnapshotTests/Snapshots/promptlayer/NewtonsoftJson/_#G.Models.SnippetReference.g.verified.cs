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
        [global::Newtonsoft.Json.JsonProperty("prompt_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// The version number of the snippet used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// The release label of the snippet, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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