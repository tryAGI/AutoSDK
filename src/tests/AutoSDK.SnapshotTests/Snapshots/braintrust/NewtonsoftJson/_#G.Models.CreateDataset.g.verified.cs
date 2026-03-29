//HintName: G.Models.CreateDataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDataset
    {
        /// <summary>
        /// Unique identifier for the project that the dataset belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the dataset. Within a project, dataset names are unique
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// User-controlled metadata about the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataset" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the dataset belongs under
        /// </param>
        /// <param name="name">
        /// Name of the dataset. Within a project, dataset names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the dataset
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the dataset
        /// </param>
        public CreateDataset(
            global::System.Guid projectId,
            string name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataset" /> class.
        /// </summary>
        public CreateDataset()
        {
        }
    }
}