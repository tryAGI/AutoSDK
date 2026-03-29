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
        [global::Newtonsoft.Json.JsonProperty("prompt_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BasePromptTemplate PromptTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptVersion PromptVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptTemplate" /> class.
        /// </summary>
        /// <param name="promptTemplate"></param>
        /// <param name="promptVersion"></param>
        /// <param name="releaseLabels"></param>
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