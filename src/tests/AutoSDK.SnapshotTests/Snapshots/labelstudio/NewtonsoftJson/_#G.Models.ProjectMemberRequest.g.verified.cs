//HintName: G.Models.ProjectMemberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectMemberRequest
    {
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
        /// Initializes a new instance of the <see cref="ProjectMemberRequest" /> class.
        /// </summary>
        /// <param name="user"></param>
        public ProjectMemberRequest(
            int user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberRequest" /> class.
        /// </summary>
        public ProjectMemberRequest()
        {
        }
    }
}