//HintName: G.Models.PromptVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTemplate3 PromptTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        /// <param name="promptTemplate"></param>
        /// <param name="commitMessage"></param>
        /// <param name="metadata"></param>
        public PromptVersion(
            global::G.PromptTemplate3 promptTemplate,
            string? commitMessage,
            global::G.Metadata? metadata)
        {
            this.PromptTemplate = promptTemplate;
            this.CommitMessage = commitMessage;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        public PromptVersion()
        {
        }
    }
}