//HintName: G.Models.CreatePromptTemplateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptTemplateResponse
    {
        /// <summary>
        /// The ID of the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// The ID of the created prompt version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptVersionId { get; set; } = default!;

        /// <summary>
        /// The version number of the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTemplate4 PromptTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptTemplateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the prompt template.
        /// </param>
        /// <param name="promptName">
        /// The name of the prompt template.
        /// </param>
        /// <param name="promptVersionId">
        /// The ID of the created prompt version.
        /// </param>
        /// <param name="versionNumber">
        /// The version number of the prompt template.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="releaseLabels"></param>
        /// <param name="metadata"></param>
        /// <param name="commitMessage"></param>
        public CreatePromptTemplateResponse(
            int id,
            string promptName,
            int promptVersionId,
            int versionNumber,
            global::System.Collections.Generic.IList<string> tags,
            global::G.PromptTemplate4 promptTemplate,
            global::System.Collections.Generic.IList<string>? releaseLabels,
            global::G.Metadata? metadata,
            string? commitMessage)
        {
            this.Id = id;
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.PromptVersionId = promptVersionId;
            this.VersionNumber = versionNumber;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.ReleaseLabels = releaseLabels;
            this.PromptTemplate = promptTemplate;
            this.Metadata = metadata;
            this.CommitMessage = commitMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptTemplateResponse" /> class.
        /// </summary>
        public CreatePromptTemplateResponse()
        {
        }
    }
}