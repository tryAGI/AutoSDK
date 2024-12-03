//HintName: G.Models.ProjectApiKeyOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectApiKeyOwner
    {
        /// <summary>
        /// `user` or `service_account`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ProjectApiKeyOwnerType? Type { get; set; }

        /// <summary>
        /// Represents an individual user in a project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.ProjectUser? User { get; set; }

        /// <summary>
        /// Represents an individual service account in a project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account")]
        public global::G.ProjectServiceAccount? ServiceAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyOwner" /> class.
        /// </summary>
        /// <param name="type">
        /// `user` or `service_account`
        /// </param>
        /// <param name="user">
        /// Represents an individual user in a project.
        /// </param>
        /// <param name="serviceAccount">
        /// Represents an individual service account in a project.
        /// </param>
        public ProjectApiKeyOwner(
            global::G.ProjectApiKeyOwnerType? type,
            global::G.ProjectUser? user,
            global::G.ProjectServiceAccount? serviceAccount)
        {
            this.Type = type;
            this.User = user;
            this.ServiceAccount = serviceAccount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyOwner" /> class.
        /// </summary>
        public ProjectApiKeyOwner()
        {
        }
    }
}