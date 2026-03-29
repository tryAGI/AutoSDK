//HintName: G.Models.PromptVersionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minor_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MinorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("major_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MajorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_v2", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptV2 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("helicone_template", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeliconeTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_prompt_version")]
        public string? ParentPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_id")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="minorVersion"></param>
        /// <param name="majorVersion"></param>
        /// <param name="promptV2"></param>
        /// <param name="model"></param>
        /// <param name="heliconeTemplate"></param>
        /// <param name="createdAt"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="parentPromptVersion"></param>
        /// <param name="experimentId"></param>
        /// <param name="updatedAt"></param>
        public PromptVersionResult(
            string id,
            double minorVersion,
            double majorVersion,
            string promptV2,
            string model,
            string heliconeTemplate,
            string createdAt,
            global::G.RecordStringAny metadata,
            string? parentPromptVersion,
            string? experimentId,
            string? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MinorVersion = minorVersion;
            this.MajorVersion = majorVersion;
            this.PromptV2 = promptV2 ?? throw new global::System.ArgumentNullException(nameof(promptV2));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.HeliconeTemplate = heliconeTemplate ?? throw new global::System.ArgumentNullException(nameof(heliconeTemplate));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ParentPromptVersion = parentPromptVersion;
            this.ExperimentId = experimentId;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionResult" /> class.
        /// </summary>
        public PromptVersionResult()
        {
        }
    }
}