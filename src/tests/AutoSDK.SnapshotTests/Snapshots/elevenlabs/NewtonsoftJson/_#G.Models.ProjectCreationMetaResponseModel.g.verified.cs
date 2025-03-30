//HintName: G.Models.ProjectCreationMetaResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectCreationMetaResponseModel
    {
        /// <summary>
        /// The progress of the project creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_progress", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreationProgress { get; set; } = default!;

        /// <summary>
        /// The status of the project creation action.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectCreationMetaResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// The type of the project creation action.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectCreationMetaResponseModelType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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