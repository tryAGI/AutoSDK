//HintName: G.Models.ProjectRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectRole
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.Role9e7EnumJsonConverter))]
        public global::G.Role9e7Enum Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public int User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRole" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="role">
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="user"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public ProjectRole(
            int project,
            global::G.Role9e7Enum role,
            int user,
            int id = default!)
        {
            this.Id = id;
            this.Project = project;
            this.Role = role;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRole" /> class.
        /// </summary>
        public ProjectRole()
        {
        }
    }
}