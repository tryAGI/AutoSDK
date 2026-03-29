//HintName: G.Models.CreatePromptTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BasePromptTemplate PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptVersion PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptTemplate" /> class.
        /// </summary>
        /// <param name="promptTemplate"></param>
        /// <param name="promptVersion"></param>
        /// <param name="releaseLabels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePromptTemplate(
            global::G.BasePromptTemplate promptTemplate,
            global::G.PromptVersion promptVersion,
            global::System.Collections.Generic.IList<string>? releaseLabels)
        {
            this.PromptTemplate = promptTemplate ?? throw new global::System.ArgumentNullException(nameof(promptTemplate));
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.ReleaseLabels = releaseLabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptTemplate" /> class.
        /// </summary>
        public CreatePromptTemplate()
        {
        }
    }
}