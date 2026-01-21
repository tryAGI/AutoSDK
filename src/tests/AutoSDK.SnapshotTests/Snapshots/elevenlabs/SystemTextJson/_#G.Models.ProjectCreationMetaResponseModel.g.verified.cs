//HintName: G.Models.ProjectCreationMetaResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"creation_progress":0.5,"status":"pending","type":"blank"}
    /// </summary>
    public sealed partial class ProjectCreationMetaResponseModel
    {
        /// <summary>
        /// The progress of the project creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreationProgress { get; set; }

        /// <summary>
        /// The status of the project creation action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectCreationMetaResponseModelStatus Status { get; set; }

        /// <summary>
        /// The type of the project creation action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectCreationMetaResponseModelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreationMetaResponseModel" /> class.
        /// </summary>
        /// <param name="creationProgress">
        /// The progress of the project creation.
        /// </param>
        /// <param name="status">
        /// The status of the project creation action.
        /// </param>
        /// <param name="type">
        /// The type of the project creation action.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCreationMetaResponseModel(
            double creationProgress,
            global::G.ProjectCreationMetaResponseModelStatus status,
            global::G.ProjectCreationMetaResponseModelType type)
        {
            this.CreationProgress = creationProgress;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreationMetaResponseModel" /> class.
        /// </summary>
        public ProjectCreationMetaResponseModel()
        {
        }
    }
}