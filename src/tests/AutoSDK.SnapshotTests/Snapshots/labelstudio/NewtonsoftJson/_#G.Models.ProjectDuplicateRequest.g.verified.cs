//HintName: G.Models.ProjectDuplicateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectDuplicateRequest
    {
        /// <summary>
        /// Project Description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// What to Duplicate (Project configuration only / Project configuration and tasks)<br/>
        /// * `settings` - Only settings<br/>
        /// * `settings,data` - Settings and tasks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModeEnum Mode { get; set; } = default!;

        /// <summary>
        /// Project Name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Destination Workspace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace", Required = global::Newtonsoft.Json.Required.Always)]
        public int Workspace { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDuplicateRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// What to Duplicate (Project configuration only / Project configuration and tasks)<br/>
        /// * `settings` - Only settings<br/>
        /// * `settings,data` - Settings and tasks
        /// </param>
        /// <param name="title">
        /// Project Name
        /// </param>
        /// <param name="workspace">
        /// Destination Workspace
        /// </param>
        /// <param name="description">
        /// Project Description
        /// </param>
        public ProjectDuplicateRequest(
            global::G.ModeEnum mode,
            string title,
            int workspace,
            string? description)
        {
            this.Description = description;
            this.Mode = mode;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDuplicateRequest" /> class.
        /// </summary>
        public ProjectDuplicateRequest()
        {
        }
    }
}