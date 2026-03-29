//HintName: G.Models.ExperimentV2PromptVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentV2PromptVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_id")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("helicone_template")]
        public global::G.Json? HeliconeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("major_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MajorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Json? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minor_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MinorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public string Organization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_v2", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptV2 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soft_delete")]
        public bool? SoftDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentV2PromptVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="majorVersion"></param>
        /// <param name="minorVersion"></param>
        /// <param name="organization"></param>
        /// <param name="promptV2"></param>
        /// <param name="createdAt"></param>
        /// <param name="experimentId"></param>
        /// <param name="heliconeTemplate"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="softDelete"></param>
        public ExperimentV2PromptVersion(
            string id,
            double majorVersion,
            double minorVersion,
            string organization,
            string promptV2,
            string? createdAt,
            string? experimentId,
            global::G.Json? heliconeTemplate,
            global::G.Json? metadata,
            string? model,
            bool? softDelete)
        {
            this.CreatedAt = createdAt;
            this.ExperimentId = experimentId;
            this.HeliconeTemplate = heliconeTemplate;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MajorVersion = majorVersion;
            this.Metadata = metadata;
            this.MinorVersion = minorVersion;
            this.Model = model;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.PromptV2 = promptV2 ?? throw new global::System.ArgumentNullException(nameof(promptV2));
            this.SoftDelete = softDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentV2PromptVersion" /> class.
        /// </summary>
        public ExperimentV2PromptVersion()
        {
        }
    }
}