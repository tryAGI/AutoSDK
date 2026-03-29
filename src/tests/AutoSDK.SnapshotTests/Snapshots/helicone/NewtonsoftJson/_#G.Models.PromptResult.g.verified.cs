//HintName: G.Models.PromptResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_defined_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserDefinedId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pretty_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PrettyName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("major_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MajorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LatestVersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_model_used", Required = global::Newtonsoft.Json.Required.Always)]
        public string LatestModelUsed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastUsed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Versions { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userDefinedId"></param>
        /// <param name="description"></param>
        /// <param name="prettyName"></param>
        /// <param name="majorVersion"></param>
        /// <param name="latestVersionId"></param>
        /// <param name="latestModelUsed"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUsed"></param>
        /// <param name="versions"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public PromptResult(
            string id,
            string userDefinedId,
            string description,
            string prettyName,
            double majorVersion,
            string latestVersionId,
            string latestModelUsed,
            string createdAt,
            string lastUsed,
            global::System.Collections.Generic.IList<string> versions,
            global::G.RecordStringAny? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PrettyName = prettyName ?? throw new global::System.ArgumentNullException(nameof(prettyName));
            this.MajorVersion = majorVersion;
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.LatestModelUsed = latestModelUsed ?? throw new global::System.ArgumentNullException(nameof(latestModelUsed));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.LastUsed = lastUsed ?? throw new global::System.ArgumentNullException(nameof(lastUsed));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResult" /> class.
        /// </summary>
        public PromptResult()
        {
        }
    }
}