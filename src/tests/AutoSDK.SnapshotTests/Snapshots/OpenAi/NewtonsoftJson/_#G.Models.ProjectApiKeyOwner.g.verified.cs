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
    }
}