//HintName: G.Models.CreateNewPromptVersionForExperimentParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateNewPromptVersionForExperimentParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newHeliconeTemplate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object NewHeliconeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMajorVersion")]
        public bool? IsMajorVersion { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bumpForMajorPromptVersionId")]
        public string? BumpForMajorPromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentPromptVersionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentPromptVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewPromptVersionForExperimentParams" /> class.
        /// </summary>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="parentPromptVersionId"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentId"></param>
        /// <param name="bumpForMajorPromptVersionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNewPromptVersionForExperimentParams(
            object newHeliconeTemplate,
            string parentPromptVersionId,
            bool? isMajorVersion,
            global::G.RecordStringAny? metadata,
            string? experimentId,
            string? bumpForMajorPromptVersionId)
        {
            this.NewHeliconeTemplate = newHeliconeTemplate ?? throw new global::System.ArgumentNullException(nameof(newHeliconeTemplate));
            this.IsMajorVersion = isMajorVersion;
            this.Metadata = metadata;
            this.ExperimentId = experimentId;
            this.BumpForMajorPromptVersionId = bumpForMajorPromptVersionId;
            this.ParentPromptVersionId = parentPromptVersionId ?? throw new global::System.ArgumentNullException(nameof(parentPromptVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewPromptVersionForExperimentParams" /> class.
        /// </summary>
        public CreateNewPromptVersionForExperimentParams()
        {
        }
    }
}