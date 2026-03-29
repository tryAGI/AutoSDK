//HintName: G.Models.CreateProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProject
    {
        /// <summary>
        /// Name of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project belongs in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProject" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Textual description of the project
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project belongs in.
        /// </param>
        public CreateProject(
            string name,
            string? description,
            string? orgName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.OrgName = orgName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProject" /> class.
        /// </summary>
        public CreateProject()
        {
        }
    }
}