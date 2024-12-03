//HintName: G.Models.ProjectsV2SingleSelectOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An option for a single select field
    /// </summary>
    public sealed partial class ProjectsV2SingleSelectOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2SingleSelectOption" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="description"></param>
        public ProjectsV2SingleSelectOption(
            string id,
            string name,
            string? color,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2SingleSelectOption" /> class.
        /// </summary>
        public ProjectsV2SingleSelectOption()
        {
        }
    }
}