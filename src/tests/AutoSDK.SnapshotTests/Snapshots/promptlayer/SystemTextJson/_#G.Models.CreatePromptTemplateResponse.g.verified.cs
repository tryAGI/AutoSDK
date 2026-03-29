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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptName { get; set; }

        /// <summary>
        /// The ID of the created prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptVersionId { get; set; }

        /// <summary>
        /// The version number of the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptTemplate4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptTemplate4 PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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