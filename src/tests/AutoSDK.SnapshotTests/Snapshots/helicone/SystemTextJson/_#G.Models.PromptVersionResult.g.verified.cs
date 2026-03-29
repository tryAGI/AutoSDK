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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minor_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MajorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helicone_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeliconeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecordStringAny Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_prompt_version")]
        public string? ParentPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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