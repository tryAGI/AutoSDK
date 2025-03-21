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
        /// Represents an individual service account in a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public global::G.ProjectServiceAccount? ServiceAccount { get; set; }

        /// <summary>
        /// `user` or `service_account`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectApiKeyOwnerTypeJsonConverter))]
        public global::G.ProjectApiKeyOwnerType? Type { get; set; }

        /// <summary>
        /// Represents an individual user in a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.ProjectUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyOwner" /> class.
        /// </summary>
        /// <param name="serviceAccount">
        /// Represents an individual service account in a project.
        /// </param>
        /// <param name="type">
        /// `user` or `service_account`
        /// </param>
        /// <param name="user">
        /// Represents an individual user in a project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectApiKeyOwner(
            global::G.ProjectServiceAccount? serviceAccount,
            global::G.ProjectApiKeyOwnerType? type,
            global::G.ProjectUser? user)
        {
            this.ServiceAccount = serviceAccount;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyOwner" /> class.
        /// </summary>
        public ProjectApiKeyOwner()
        {
        }
    }
}