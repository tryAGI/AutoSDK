//HintName: G.Models.CreateExperimentTableParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentTableParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentMetadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny ExperimentMetadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newHeliconeTemplate", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewHeliconeTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isMajorVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsMajorVersion { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptSubversionMetadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny PromptSubversionMetadata { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentTableMetadata")]
        public global::G.RecordStringAny? ExperimentTableMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableParams" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="experimentMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="promptVersionId"></param>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="promptSubversionMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentTableMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public CreateExperimentTableParams(
            string datasetId,
            global::G.RecordStringAny experimentMetadata,
            string promptVersionId,
            string newHeliconeTemplate,
            bool isMajorVersion,
            global::G.RecordStringAny promptSubversionMetadata,
            global::G.RecordStringAny? experimentTableMetadata)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.ExperimentMetadata = experimentMetadata ?? throw new global::System.ArgumentNullException(nameof(experimentMetadata));
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
            this.NewHeliconeTemplate = newHeliconeTemplate ?? throw new global::System.ArgumentNullException(nameof(newHeliconeTemplate));
            this.IsMajorVersion = isMajorVersion;
            this.PromptSubversionMetadata = promptSubversionMetadata ?? throw new global::System.ArgumentNullException(nameof(promptSubversionMetadata));
            this.ExperimentTableMetadata = experimentTableMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableParams" /> class.
        /// </summary>
        public CreateExperimentTableParams()
        {
        }
    }
}