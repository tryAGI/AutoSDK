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
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecordStringAny ExperimentMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newHeliconeTemplate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewHeliconeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMajorVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMajorVersion { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptSubversionMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecordStringAny PromptSubversionMetadata { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentTableMetadata")]
        public global::G.RecordStringAny? ExperimentTableMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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