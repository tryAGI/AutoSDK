//HintName: G.Models.Prompt2025Version.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025Version
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MajorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minor_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_url")]
        public string? S3Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_body")]
        public global::G.Prompt2025VersionPromptBody? PromptBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025Version" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="promptId"></param>
        /// <param name="majorVersion"></param>
        /// <param name="minorVersion"></param>
        /// <param name="commitMessage"></param>
        /// <param name="createdAt"></param>
        /// <param name="environments"></param>
        /// <param name="s3Url"></param>
        /// <param name="promptBody"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt2025Version(
            string id,
            string model,
            string promptId,
            double majorVersion,
            double minorVersion,
            string commitMessage,
            string createdAt,
            global::System.Collections.Generic.IList<string>? environments,
            string? s3Url,
            global::G.Prompt2025VersionPromptBody? promptBody)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
            this.CommitMessage = commitMessage ?? throw new global::System.ArgumentNullException(nameof(commitMessage));
            this.Environments = environments;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.S3Url = s3Url;
            this.PromptBody = promptBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025Version" /> class.
        /// </summary>
        public Prompt2025Version()
        {
        }
    }
}