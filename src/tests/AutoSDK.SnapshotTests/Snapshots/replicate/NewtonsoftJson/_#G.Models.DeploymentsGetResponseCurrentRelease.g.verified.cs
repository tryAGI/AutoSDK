//HintName: G.Models.DeploymentsGetResponseCurrentRelease.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsGetResponseCurrentRelease
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.DeploymentsGetResponseCurrentReleaseConfiguration? Configuration { get; set; }

        /// <summary>
        /// The time the release was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.DeploymentsGetResponseCurrentReleaseCreatedBy? CreatedBy { get; set; }

        /// <summary>
        /// The model identifier string in the format of `{model_owner}/{model_name}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The release number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number")]
        public int? Number { get; set; }

        /// <summary>
        /// The ID of the model version used in the release.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponseCurrentRelease" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="createdAt">
        /// The time the release was created.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="model">
        /// The model identifier string in the format of `{model_owner}/{model_name}`.
        /// </param>
        /// <param name="number">
        /// The release number.
        /// </param>
        /// <param name="version">
        /// The ID of the model version used in the release.
        /// </param>
        public DeploymentsGetResponseCurrentRelease(
            global::G.DeploymentsGetResponseCurrentReleaseConfiguration? configuration,
            global::System.DateTime? createdAt,
            global::G.DeploymentsGetResponseCurrentReleaseCreatedBy? createdBy,
            string? model,
            int? number,
            string? version)
        {
            this.Configuration = configuration;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Model = model;
            this.Number = number;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponseCurrentRelease" /> class.
        /// </summary>
        public DeploymentsGetResponseCurrentRelease()
        {
        }
    }
}