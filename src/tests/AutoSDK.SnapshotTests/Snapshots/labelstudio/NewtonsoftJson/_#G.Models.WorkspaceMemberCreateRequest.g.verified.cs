//HintName: G.Models.WorkspaceMemberCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMemberCreateRequest
    {
        /// <summary>
        /// User ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public int User { get; set; } = default!;

        /// <summary>
        /// Workspace ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberCreateRequest" /> class.
        /// </summary>
        /// <param name="user">
        /// User ID
        /// </param>
        /// <param name="workspace">
        /// Workspace ID
        /// </param>
        public WorkspaceMemberCreateRequest(
            int user,
            int? workspace)
        {
            this.User = user;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberCreateRequest" /> class.
        /// </summary>
        public WorkspaceMemberCreateRequest()
        {
        }
    }
}