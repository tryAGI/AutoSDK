//HintName: G.Models.AddProjectResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectResponseModel Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectResponseModel" /> class.
        /// </summary>
        /// <param name="project"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddProjectResponseModel(
            global::G.ProjectResponseModel project)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectResponseModel" /> class.
        /// </summary>
        public AddProjectResponseModel()
        {
        }
    }
}