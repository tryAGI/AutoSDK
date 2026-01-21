//HintName: G.Models.WorkspaceGroupByNameResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"1234567890","members_emails":["john.doe@example.com","jane.smith@example.com"],"name":"My Workspace Group"}
    /// </summary>
    public sealed partial class WorkspaceGroupByNameResponseModel
    {
        /// <summary>
        /// The name of the workspace group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the workspace group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The emails of the members of the workspace group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_emails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> MembersEmails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceGroupByNameResponseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the workspace group.
        /// </param>
        /// <param name="id">
        /// The ID of the workspace group.
        /// </param>
        /// <param name="membersEmails">
        /// The emails of the members of the workspace group.
        /// </param>
        public WorkspaceGroupByNameResponseModel(
            string name,
            string id,
            global::System.Collections.Generic.IList<string> membersEmails)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MembersEmails = membersEmails ?? throw new global::System.ArgumentNullException(nameof(membersEmails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceGroupByNameResponseModel" /> class.
        /// </summary>
        public WorkspaceGroupByNameResponseModel()
        {
        }
    }
}