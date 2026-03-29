//HintName: G.Models.PromptCreateSubversionParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCreateSubversionParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newHeliconeTemplate", Required = global::Newtonsoft.Json.Required.Always)]
        public object NewHeliconeTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isMajorVersion")]
        public bool? IsMajorVersion { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentId")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bumpForMajorPromptVersionId")]
        public string? BumpForMajorPromptVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCreateSubversionParams" /> class.
        /// </summary>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentId"></param>
        /// <param name="bumpForMajorPromptVersionId"></param>
        public PromptCreateSubversionParams(
            object newHeliconeTemplate,
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCreateSubversionParams" /> class.
        /// </summary>
        public PromptCreateSubversionParams()
        {
        }
    }
}