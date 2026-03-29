//HintName: G.Models.PromptsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptsResult
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
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("major_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MajorVersion { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PromptsResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userDefinedId"></param>
        /// <param name="description"></param>
        /// <param name="prettyName"></param>
        /// <param name="createdAt"></param>
        /// <param name="majorVersion"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public PromptsResult(
            string id,
            string userDefinedId,
            string description,
            string prettyName,
            string createdAt,
            double majorVersion,
            global::G.RecordStringAny? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PrettyName = prettyName ?? throw new global::System.ArgumentNullException(nameof(prettyName));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.MajorVersion = majorVersion;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsResult" /> class.
        /// </summary>
        public PromptsResult()
        {
        }
    }
}