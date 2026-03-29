//HintName: G.Models.CreateProjectTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectTag
    {
        /// <summary>
        /// Unique identifier for the project that the project tag belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the project tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the project tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color of the tag for the UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectTag" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project tag belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project tag
        /// </param>
        /// <param name="description">
        /// Textual description of the project tag
        /// </param>
        /// <param name="color">
        /// Color of the tag for the UI
        /// </param>
        public CreateProjectTag(
            global::System.Guid projectId,
            string name,
            string? description,
            string? color)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectTag" /> class.
        /// </summary>
        public CreateProjectTag()
        {
        }
    }
}