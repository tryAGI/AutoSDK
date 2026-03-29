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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helicone_template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonJsonConverter))]
        public global::G.Json? HeliconeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MajorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonJsonConverter))]
        public global::G.Json? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minor_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_delete")]
        public bool? SoftDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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