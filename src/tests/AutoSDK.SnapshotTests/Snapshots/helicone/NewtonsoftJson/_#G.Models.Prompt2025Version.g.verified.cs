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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("major_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MajorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minor_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MinorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitMessage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3_url")]
        public string? S3Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_body")]
        public global::G.Prompt2025VersionPromptBody? PromptBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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